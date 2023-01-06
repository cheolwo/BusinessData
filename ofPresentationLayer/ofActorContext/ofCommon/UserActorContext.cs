using BusinessView.ofCommon.ofServices;
using NMemory.Tables;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using BusinessData.ofPresentationLayer.ofDTOServices;
using System.Linq;
using System.Collections.Generic;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class UserActorContext : ActorContext
    {
        protected ActorServiceOption _options = new();
        private IdentityUser _identityUser = new();
        public UserActorContext(ActorServiceOption options)
        {
            _options = options;
        }
        public virtual void OnConfigureActor(IdentityUser identityUser)
        {
            _identityUser = identityUser;
        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            serviceBuilder.Add(nameof(IdentityUserDTO), new IdentityUserDTOService(_options.DTOServiceOptions));
        }

        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {
        }

        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilder)
        {
        }
        /*
        //  1. Validate 단계  
            (1) 성공시 Service.PostAsync(t) 를 실행
            (2) 실패시 예외처리
        //  2. Service 단계
                Post 할 파일이 있는 경우 MemoryStream 으로 변환하여 Post 하는 단계
        //     (1). 성공 시 Service 값을 스토리지에 저장하는 단계
        //     (2)  실패 시 thorw 하는 단계를 포함하는 PostAsync() 프로세스
        
            3. Storage 단게
                PostValue를 InMemeoryDatabase 에 저장하는 단계
         */
        public override IValidator<T> GetValidator<T>() 
        {
            IValidator<T> validator = (IValidator<T>)ValidatorBuilder.Get(typeof(T).Name);
            if (validator == null) { throw new NullReferenceException(nameof(IValidator<T>)); }
            return validator;
        }
        public override ITable<T> GetMemoryTable<T>() 
        {
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);
            if (storage == null) { throw new NullReferenceException(nameof(ITable<T>)); }
            return storage;
        }
        public override DTOService GetDTOService<T>() 
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            if (service == null) { throw new NullReferenceException(nameof(DTOService)); }
            return service;
        }
        public override async Task<T> PostAsync<T>(T t)
        {
            if (t == null) { throw new ArgumentNullException(nameof(T)); }

            DTOService service = GetDTOService<T>();
            ITable<T> storage = GetMemoryTable<T>();
            IValidator<T> validator = GetValidator<T>();
            var validateResult = validator.Validate(t);
            if(validateResult.IsValid)
            {
                T Value = await service.PostAsync(t);
                if (Value != null) { storage.Insert(Value); return Value; }
                else { throw new NullReferenceException("POST_RETURN_VALUE_NULL"); }
            }
            else { throw new ArgumentException("NOT_VALIDATE"); }
        }
        public override async Task<T> PostAsync<T>(T t, MultipartFormDataContent content)
        {
            if (t == null) { throw new ArgumentNullException(nameof(T)); }

            DTOService service = GetDTOService<T>();
            ITable<T> storage = GetMemoryTable<T>();
            IValidator<T> validator = GetValidator<T>();

            T Value = await service.PostAsync<T>(t, content);
            if (Value != null) { storage.Insert(Value); return Value; }
            else { throw new NullReferenceException("PostService Value Is Null"); }
        }
        /*
            1. Validate 단계
            2. Service 단계
                1, 2 단계의 경우 Post 와 유사 PutAsync() 를 이용한다는 점이 다름.
            3. Storage 단계
                (1) Storage 에 있는 PostValue 를 확인
                (2) 없을 경우 PutValue를 삽입
                (3) 있을 경우 삭제하고 PutValue를 삽입
        */
        public override async Task<T> PutAsync<T>(T t)
        {
            if (t == null) { throw new ArgumentNullException(nameof(T)); }

            DTOService service = GetDTOService<T>();
            ITable<T> storage = GetMemoryTable<T>();
            IValidator<T> validator = GetValidator<T>();

            var Result = validator.Validate(t);
            if (Result.IsValid)
            {
                var StorageValue = storage.FirstOrDefault(e => e.Equals(t));
                if (StorageValue != null) { storage.Delete(StorageValue); }
                T Value = await service.PutAsync<T>(t);
                if (Value != null)
                {
                    storage.Insert(Value);
                    return Value;
                }
                else { throw new NullReferenceException("PutService Value Is Null"); }
            }
            else
            {
                throw new ValidationException("It is Not Validate");
            }
        }
        /*
            1. Storage Value 값 조회 단계
                (1) 있을 경우 반환하고 스레드 종료
                (2) 없을 경우 Service 단계 실행
            2. Service GetByIdAsync() 단계
                (1) 있을 경우 값의 User Id와 IdentityUserId가 같은지 확인
                     (1) - 1 같은 경우 Storage에 저장하고 반환
                     (1) - 2 같지 않은 경우 유저 불일치 예외발생
                (2) 없을 경우 예외발생
                UserActorContext.GetByIdAsync<T>(string id) 는 유저와 관련한 객체만읆 Return 하는 것을
                특징으로 한다.
        */
        public override async Task<T> GetByIdAsync<T>(string id)
        {
            DTOService service = GetDTOService<T>();
            ITable<T> storage = GetMemoryTable<T>();

            var StorageValue = storage.FirstOrDefault(e => e.EqualsById(id));
            if (StorageValue != null) { return StorageValue; }
            else
            {
                var ServiceValue = await service.GetByIdAsync<T>(id);
                if (ServiceValue != null) { return ServiceValue; }
                else { throw new NullReferenceException("Service Value Is Null"); }
            }
        }
        /*

        */
        public override async Task DeleteByIdAsync<T>(string id)
        {
            DTOService service = GetDTOService<T>();
            ITable<T> storage = GetMemoryTable<T>();

            var StorageValue = storage.FirstOrDefault(e => e.EqualsById(id));
            if (StorageValue != null) { storage.Delete(StorageValue); }

            await service.DeleteAsync<T>(id);
        }

        public override async Task<IEnumerable<T>> GetsAsync<T>()
        {
            DTOService service = GetDTOService<T>();
            ITable<T> storage = GetMemoryTable<T>();
            if (storage.Count > 0) { return storage.ToList(); }
            else
            {
                var ServiceValue = await service.GetsAsync<T>();
                if (ServiceValue != null) { return ServiceValue; }
                else { throw new NullReferenceException("Service Value Is Null"); }
            }
        }

        public override async Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid)
        {
            DTOService service = GetDTOService<T>();
            ITable<T> storage = GetMemoryTable<T>();
            if (storage.Count > 0) { return storage.ToList(); }
            else
            {
                var ServiceValue = await service.GetsAsyncByUserId<T>(userid);
                if (ServiceValue != null) { return ServiceValue; }
                else { throw new NullReferenceException("Service Value Is Null"); }
            }
        }
    }
}
