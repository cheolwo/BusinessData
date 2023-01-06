using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofGeneric
{
    public class CenterPasswordHasher<TEntity> : IPasswordHasher<TEntity> where TEntity : Center
    {
        public string HashPassword(TEntity entity, string password)
        {
            byte[] keyByte = Encoding.UTF8.GetBytes(entity.UserId);
            HMACSHA256 hMACSHA256 = new(keyByte);
            byte[] passbyte = Encoding.UTF8.GetBytes(password);
            return hMACSHA256.ComputeHash(passbyte).Aggregate("", (s, e) => s + e.ToString("X2"), s => s);
        }

        public PasswordVerificationResult VerifyHashedPassword(TEntity entity, string hashedPassword, string providedPassword)
        {
            string ProvidedHashPassword = HashPassword(entity, providedPassword);
            if (hashedPassword.Equals(providedPassword))
            {
                return PasswordVerificationResult.Success;
            }
            else
            {
                return PasswordVerificationResult.Failed;
            }
        }
        // 생성자의 패스워드 해쉬 인터페이스를 상속받는 개체가 있어야겠다.
    }
    public interface ICenterManager<TEntity> : IEntityManager<TEntity> where TEntity : Center, new()
    {
        Task<TEntity> GetByUserAsync(IdentityUser IdentityUser);
        Task<TEntity> LoginAsync(string id, string password);
        Task<bool> LoginByCryptPasswrodAsync(TEntity entity, string id, string cryptPassword);
        Task<Dictionary<string, List<TEntity>>> ExcelToCenterEntities(string fileconnectionString, Dictionary<PropertyInfo, int> Target,
                                            int UserCodeTarget);
        Task<List<TEntity>> GetToListByUserIdWithRelatedAsync(string UserId);
        Task<List<TEntity>> GetToListWithRelatedAsync();
    }
    public class CenterManager<TEntity> : EntityManager<TEntity>, ICenterManager<TEntity> where TEntity : Center, new()
    {
        private readonly ICenterIdFactory<TEntity> _centerIdFactory;
        private readonly ICenterFileFactory<TEntity> _centerFileFactory;
        public readonly ICenterDataRepository<TEntity> _centerDataRepository;
        private readonly IPasswordHasher<TEntity> _passwordHashser;
        public CenterManager(ICenterDataRepository<TEntity> centerDataRepository,
            ICenterIdFactory<TEntity> centerIdFactory,
                            ICenterFileFactory<TEntity> centerFileFactory,
                            IEntityBlobStorage<TEntity> entityBlobStorage,
                            DicConvertFactory<TEntity> dicConvertFactory,
                            CenterPasswordHasher<TEntity> passwordHasher)
                : base(centerDataRepository, centerIdFactory, centerFileFactory, entityBlobStorage, dicConvertFactory)
        {
            _centerIdFactory = centerIdFactory;
            _centerDataRepository = centerDataRepository;
            _passwordHashser = passwordHasher;
            _centerFileFactory = centerFileFactory;
        }
        public Task<TEntity> CreateAsync(TEntity entity, string password)
        {
            string hashPassword = _passwordHashser.HashPassword(entity, password);
            entity.Password = hashPassword;
            return base.CreateAsync(entity);
        }
        public async Task<TEntity> GetEntityByPasswordAsync(IdentityUser identityUser, string password)
        {
            TEntity entity = await _centerDataRepository.GetByUserAsync(identityUser);
            var Result = _passwordHashser.VerifyHashedPassword(entity, entity.Password, password);
            if (Result.Equals(PasswordVerificationResult.Success))
            {
                return entity;
            }
            else
            {
                entity.FailLogin = entity.FailLogin++;
                await _centerDataRepository.UpdateAsync(entity);
                throw new ArgumentException("Not Concience Password");
            }
        }
        public async Task<TEntity> GetByUserAsync(IdentityUser IdentityUser)
        {
            return await _centerDataRepository.GetByUserAsync(IdentityUser);
        }

        public new async Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser)
        {
            return await _centerDataRepository.GetToListByUserAsync(IdentityUser);
        }
        // Id로 Entity를 Load 하는 단계
        // Entity Password와 입력 Password를 비교하는 단계
        // 일치할 시 Entity를 반환하고 아닌 경우 예외처리하는 단계를 포함하는
        // CenterManager 로그인 메서드
        public virtual async Task<TEntity> LoginAsync(string LoginId, string Password)
        {
            TEntity entity = await _centerDataRepository.GetByLoginIdAsync(LoginId);
            var Result = _passwordHashser.VerifyHashedPassword(entity, entity.Password, Password);
            if (Result.Equals(PasswordVerificationResult.Success)) { return entity; }
            else
            {
                entity.FailLogin = entity.FailLogin++;
                await _centerDataRepository.UpdateAsync(entity);
                throw new ArgumentException("Not Concience Password");
            }
        }

        public Task<TEntity> LoginByCryptPasswrodAsync(TEntity entity, string id, string cryptPassword)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICenterManager<TEntity>.LoginByCryptPasswrodAsync(TEntity entity, string id, string cryptPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<Dictionary<string, List<TEntity>>> ExcelToCenterEntities(string fileconnectionString, Dictionary<PropertyInfo, int> Target,
                                            int UserCodeTarget)
        {
            int count = await _EntityDataRepository.GetCountAsync();
            var datas = _EntityFileFactory.InitExcelData(fileconnectionString);
            var UserKeyCenterValue = _centerFileFactory.SetExcelCenters(datas, Target, UserCodeTarget);
            return _centerIdFactory.SetUserKeyCenterValueId(UserKeyCenterValue, count);
        }

        public Task<List<TEntity>> GetToListByUserIdWithRelatedAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetToListWithRelatedAsync()
        {
            throw new NotImplementedException();
        }
    }
}