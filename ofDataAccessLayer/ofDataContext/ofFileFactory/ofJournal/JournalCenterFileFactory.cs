using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofWarehouse.ofFileFactory
{
    public interface IJournalCenterFileFactory : ICenterFileFactory<JournalCenter>
    {

    }
    public class JournalCenterFileFactory : CenterFileFactory<JournalCenter>, IJournalCenterFileFactory
    {

    }
    public interface IJCommodityFileFactory : ICommodityFileFactory<JCommodity>
    {

    }
    public class JCommodityFileFactory : CommodityFileFactory<JCommodity>, IJCommodityFileFactory
    {

    }
    public interface IJournalFileFactory : IEntityFileFactory<Journal>
    {

    }
    public class JournalFileFactory : EntityFileFactory<Journal>, IJournalFileFactory
    {

    }
    public interface IUserSettingJournalFileFactory : IEntityFileFactory<UserSettingJournal>
    {

    }
    public class UserSettingJournalFileFactory : EntityFileFactory<UserSettingJournal>, IUserSettingJournalFileFactory
    {

    }
}