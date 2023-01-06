using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using FluentValidation;
using NMemory.Tables;
using System.Net.Http;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresentationLayer.ofDTOServices;

namespace BusinessData.ofPresentationLayer.ofDTOContext
{
    public class DTOContextAttribute : Attribute
    {
        private Type _dtoContextType;
        public DTOContextAttribute(Type DTOContext)
        {
            _dtoContextType = DTOContext;
        }
        public Type _DTOContextType
        {
            get => _dtoContextType;
        }
    }
    public class DTOContext
    {
        protected ServiceBuilder ServiceBuilder = new();
        protected StorageBuilder StorageBuilder = new();
        protected ValidatorBuilder ValidatorBuilder = new();
        public DTOContext()
        {
            OnServiceBuilder(ServiceBuilder);
            OnValidatorBuilder(ValidatorBuilder);
            OnStrorageBuilder(StorageBuilder);
        }
        protected virtual void OnServiceBuilder(ServiceBuilder serviceBuilder) { }
        protected virtual void OnStrorageBuilder(StorageBuilder storageBuilder) { }
        protected virtual void OnValidatorBuilder(ValidatorBuilder validatorBuilde) { }
        public Task<T> PostAsync<T>(T t, MultipartFormDataContent content) where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public Task<T> PostAsync<T>(T t) where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public Task<T> PutAsync<T>(T t) where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public Task<T> GetByIdAsync<T>(string id) where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public Task DeleteByIdAsync<T>(string id) where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<T>> GetsAsync<T>() where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid) where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public IValidator<T> GetValidator<T>() where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public ITable<T> GetMemoryTable<T>() where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
        public DTOService GetDTOService<T>() where T : EntityDTO, new()
        {
            throw new NotImplementedException();
        }
    }
}
