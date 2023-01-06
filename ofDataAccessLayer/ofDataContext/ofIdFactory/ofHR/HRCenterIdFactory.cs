using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofHRCenter.ofRepository;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;

namespace BusinessData.ofDataAccessLayer.ofHumanResouce.ofIdFactory
{
    public interface IHRCenterIdFactory : ICenterIdFactory<HRCenter>
    {

    }
    public class HRCenterIdFactory : CenterIdFactory<HRCenter>, IHRCenterIdFactory
    {
        public HRCenterIdFactory(IHRCenterRepository HRCenterRepository)
            : base(HRCenterRepository)
        {

        }
    }
    public interface IHREmployeeIdFactory : IEntityIdFactory<HREmployee>
    {

    }
    public class HREmployeeIdFactory : EntityIdFactory<HREmployee>, IHREmployeeIdFactory
    {
        public HREmployeeIdFactory(IHREmployeeRepository HREmployeeRepository)
            : base(HREmployeeRepository)
        {

        }
    }
    public interface IHRRoleIdFactory : IEntityIdFactory<HRRole>
    {

    }
    public class HRRoleIdFactory : EntityIdFactory<HRRole>, IHRRoleIdFactory
    {
        public HRRoleIdFactory(IHRRoleRepository HRRoleRepository)
            : base(HRRoleRepository)
        {

        }
    }
    public interface IEmployeeRoleIdFactory : IEntityIdFactory<EmployeeRole>
    {

    }
    public class EmployeeRoleIdFactory : EntityIdFactory<EmployeeRole>, IEmployeeRoleIdFactory
    {
        public EmployeeRoleIdFactory(IEmployeeRoleRepository EmployeeRoleRepository)
            : base(EmployeeRoleRepository)
        {

        }
    }
    public interface IHRBusinessPartIdFactory : IEntityIdFactory<HRBusinessPart>
    {

    }
    public class HRBusinessPartIdFactory : EntityIdFactory<HRBusinessPart>, IHRBusinessPartIdFactory
    {
        public HRBusinessPartIdFactory(IHRBusinessPartRepository HRBusinessPartRepository)
            : base(HRBusinessPartRepository)
        {

        }
    }
}