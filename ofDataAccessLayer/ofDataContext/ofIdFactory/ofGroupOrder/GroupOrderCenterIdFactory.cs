using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofRepository;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofGroupOrder.ofIdFactory
{
    public interface IGOCIdFactory : ICenterIdFactory<GOC>
    {
        Task<string> CreateByKApt(GOC newGOC, KAptBasicInfo kAptBasicInfo);
    }
    public class GOCIdFactory : CenterIdFactory<GOC>, IGOCIdFactory
    {
        public GOCIdFactory(IGOCRepository GOCRepository)
            : base(GOCRepository)
        {

        }
        public async Task<string> CreateByKApt(GOC GOC, KAptBasicInfo kAptBasicInfo)
        {
            string Id = await base.CreateAsync(GOC);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Id);
            stringBuilder.Append('-');
            stringBuilder.Append("KApt");
            stringBuilder.Append('-');
            stringBuilder.Append(kAptBasicInfo.Id);
            return stringBuilder.ToString();
        }
    }
    public interface IGOCCIdFactory : ICommodityIdFactory<GOCC>
    {

    }
    public class GOCCIdFactory : CommodityIdFactory<GOCC>, IGOCCIdFactory
    {
        public GOCCIdFactory(IGOCCRepository GOCCRepository)
            : base(GOCCRepository)
        {

        }
    }
    public interface ISGOCIdFactory : IStatusIdFactory<SGOC>
    {

    }
    public class SGOCIdFactory : StatusIdFactory<SGOC>, ISGOCIdFactory
    {
        public SGOCIdFactory(ISGOCRepository SGOCRepository)
            : base(SGOCRepository)
        {

        }
    }
    public interface IMGOCIdFactory : IStatusIdFactory<MGOC>
    {

    }
    public class MGOCIdFactory : StatusIdFactory<MGOC>, IMGOCIdFactory
    {
        public MGOCIdFactory(IMGOCRepository MGOCRepository)
            : base(MGOCRepository)
        {

        }
    }
    public interface IEGOCIdFactory : IStatusIdFactory<EGOC>
    {

    }
    public class EGOCIdFactory : StatusIdFactory<EGOC>, IEGOCIdFactory
    {
        public EGOCIdFactory(IEGOCRepository EGOCRepository)
            : base(EGOCRepository)
        {

        }
    }
}