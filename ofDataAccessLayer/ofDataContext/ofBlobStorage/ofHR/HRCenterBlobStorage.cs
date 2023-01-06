using BusinessData.ofDataAccessLayer.ofHRCenter.ofRepository;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofWarehouse.ofBlobStorage
{
    public interface IHRCenterBlobContainerFactory : IEntityContainerFactory<HRCenter>
    {

    }
    public class HRCenterBlobContainerFactory : EntityContainerFactory<HRCenter>, IHRCenterBlobContainerFactory
    {
        private readonly IHRCenterRepository _HRCenterRepository;
        public HRCenterBlobContainerFactory(IHRCenterRepository HRCenterRepository)
            : base(HRCenterRepository)
        {
            _HRCenterRepository = HRCenterRepository;
        }
        public override async Task<string> CreateNameofContainer(HRCenter entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IHREmployeeBlobContainerFactory : IEntityContainerFactory<HREmployee>
    {

    }
    public class HREmployeeBlobContainerFactory : EntityContainerFactory<HREmployee>, IHREmployeeBlobContainerFactory
    {
        private readonly IHREmployeeRepository _HREmployeeRepository;
        public HREmployeeBlobContainerFactory(IHREmployeeRepository HREmployeeRepository)
            :base(HREmployeeRepository)
        {
            _HREmployeeRepository = HREmployeeRepository;
        }
        public override async Task<string> CreateNameofContainer(HREmployee entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IHRRoleBlobContainerFactory : IEntityContainerFactory<HRRole>
    {

    }
    public class HRRoleBlobContainerFactory : EntityContainerFactory<HRRole>, IHRRoleBlobContainerFactory
    {
        private readonly IHRRoleRepository _HRRoleRepository;
        public HRRoleBlobContainerFactory(IHRRoleRepository HRRoleRepository)
            :base(HRRoleRepository)
        {
            _HRRoleRepository = HRRoleRepository;
        }
        public override async Task<string> CreateNameofContainer(HRRole entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IEmployeeRoleBlobContainerFactory : IEntityContainerFactory<EmployeeRole>
    {

    }
    public class EmployeeRoleBlobContainerFactory : EntityContainerFactory<EmployeeRole>, IEmployeeRoleBlobContainerFactory
    {
        private readonly IEmployeeRoleRepository _EmployeeRoleRepository;
        public EmployeeRoleBlobContainerFactory(IEmployeeRoleRepository EmployeeRoleRepository)
            :base(EmployeeRoleRepository)
        {
            _EmployeeRoleRepository = EmployeeRoleRepository;
        }
        public override async Task<string> CreateNameofContainer(EmployeeRole entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IHRBusinessPartBlobContainerFactory : IEntityContainerFactory<HRBusinessPart>
    {

    }
    public class HRBusinessPartBlobContainerFactory : EntityContainerFactory<HRBusinessPart>, IHRBusinessPartBlobContainerFactory
    {
        private readonly IHRBusinessPartRepository _HRBusinessPartRepository;
        public HRBusinessPartBlobContainerFactory(IHRBusinessPartRepository HRBusinessPartRepository)
            :base(HRBusinessPartRepository)
        {
            _HRBusinessPartRepository = HRBusinessPartRepository;
        }
        public override async Task<string> CreateNameofContainer(HRBusinessPart entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IHRCenterBlobStorage : IEntityBlobStorage<HRCenter>
    {

    }
    public interface IHREmployeeBlobStorage : IEntityBlobStorage<HREmployee>
    {

    }
    public interface IHRRoleBlobStorage : IEntityBlobStorage<HRRole>
    {

    }
    public interface IEmployeeRoleBlobStorage : IEntityBlobStorage<EmployeeRole>
    {

    }
    public interface IHRBusinessPartBlobStorage : IEntityBlobStorage<HRBusinessPart>
    {

    }
    public class HRCenterBlobStorage : EntityBlobStorage<HRCenter>, IHRCenterBlobStorage
    {
        public HRCenterBlobStorage(IHRCenterBlobContainerFactory HRCenterBlobContainerFactory)
            : base(HRCenterBlobContainerFactory)
        {

        }
    }
    public class HREmployeeBlobStorage : EntityBlobStorage<HREmployee>, IHREmployeeBlobStorage
    {
        public HREmployeeBlobStorage(IHREmployeeBlobContainerFactory HREmployeeBlobContainerFactory)
            : base(HREmployeeBlobContainerFactory)
        {

        }

    }
    public class HRRoleBlobStorage : EntityBlobStorage<HRRole>, IHRRoleBlobStorage
    {
        public HRRoleBlobStorage(IHRRoleBlobContainerFactory HRRoleBlobContainerFactory)
            : base(HRRoleBlobContainerFactory)
        {

        }
    }
    public class EmployeeRoleBlobStorage : EntityBlobStorage<EmployeeRole>, IEmployeeRoleBlobStorage
    {
        public EmployeeRoleBlobStorage(IEmployeeRoleBlobContainerFactory EmployeeRoleBlobContainerFactory)
            : base(EmployeeRoleBlobContainerFactory)
        {

        }
    }
    public class HRBusinessPartBlobStorage : EntityBlobStorage<HRBusinessPart>, IHRBusinessPartBlobStorage
    {
        public HRBusinessPartBlobStorage(IHRBusinessPartBlobContainerFactory HRBusinessPartBlobContainerFactory)
            : base(HRBusinessPartBlobContainerFactory)
        {

        }
    }
}