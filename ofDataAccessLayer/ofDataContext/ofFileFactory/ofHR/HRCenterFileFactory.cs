using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofWarehouse.ofFileFactory
{
    public interface IHRCenterFileFactory : ICenterFileFactory<HRCenter>
    {

    }
    public class HRCenterFileFactory : CenterFileFactory<HRCenter>, IHRCenterFileFactory
    {

    }
    public interface IHREmployeeFileFactory : IEntityFileFactory<HREmployee>
    {

    }
    public class HREmployeeFileFactory : EntityFileFactory<HREmployee>, IHREmployeeFileFactory
    {

    }
    public interface IHRRoleFileFactory : IEntityFileFactory<HRRole>
    {

    }
    public class HRRoleFileFactory : EntityFileFactory<HRRole>, IHRRoleFileFactory
    {

    }
    public interface IEmployeeRoleFileFactory : IEntityFileFactory<EmployeeRole>
    {

    }
    public class EmployeeRoleFileFactory : EntityFileFactory<EmployeeRole>, IEmployeeRoleFileFactory
    {

    }
    public interface IHRBusinessPartFileFactory : IEntityFileFactory<HRBusinessPart>
    {

    }
    public class HRBusinessPartFileFactory : EntityFileFactory<HRBusinessPart>, IHRBusinessPartFileFactory
    {

    }
}