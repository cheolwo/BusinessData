using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofGroupOrder.ofFileFactory
{
    public interface IGOCFileFactory : ICenterFileFactory<GOC>
    {

    }
    public class GOCFileFactory : CenterFileFactory<GOC>, IGOCFileFactory
    {

    }
    public interface IGOCCFileFactory : ICommodityFileFactory<GOCC>
    {

    }
    public class GOCCFileFactory : CommodityFileFactory<GOCC>, IGOCCFileFactory
    {

    }
    public interface ISGOCFileFactory : IStatusFileFactory<SGOC>
    {

    }
    public class SGOCFileFactory : StatusFileFactory<SGOC>, ISGOCFileFactory
    {

    }
    public interface IMGOCFileFactory : IStatusFileFactory<MGOC>
    {

    }
    public class MGOCFileFactory : StatusFileFactory<MGOC>, IMGOCFileFactory
    {

    }
    public interface IEGOCFileFactory : IStatusFileFactory<EGOC>
    {

    }
    public class EGOCFileFactory : StatusFileFactory<EGOC>, IEGOCFileFactory
    {

    }
}