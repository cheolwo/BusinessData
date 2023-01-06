using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;

namespace BusinessLogic.ofEntityManager.ofJournal.ofBlobStorage
{
    public interface IJournalCenterBlobContainerFactory : IEntityContainerFactory<JournalCenter>
    {

    }
    public interface IJournalBlobContainerFactory : IEntityContainerFactory<Journal>
    {

    }
    public interface IJCommodityBlobContainerFactory : IEntityContainerFactory<JCommodity>
    {

    }
    public interface IUserSettingJournalBlobContainerFactory : IEntityContainerFactory<UserSettingJournal>
    {

    }
    public interface IJournalCenterBlobStorage : IEntityBlobStorage<JournalCenter>
    {

    }
    public interface IJCommodityBlobStorage : IEntityBlobStorage<JCommodity>
    {

    }
    public interface IJournalBlobStorage : IEntityBlobStorage<Journal>
    {

    }
    public interface IUserSettingJournalBlobStorage : IEntityBlobStorage<UserSettingJournal>
    {

    }
    public class JournalCenterBlobStorage : EntityBlobStorage<JournalCenter>, IJournalCenterBlobStorage
    {
        public JournalCenterBlobStorage(IJournalCenterBlobContainerFactory JournalCenterBlobContainerFactory)
            :base(JournalCenterBlobContainerFactory)
        {

        }
    }
    public class JournalBlobStorage : EntityBlobStorage<Journal>, IJournalBlobStorage
    {
        public JournalBlobStorage(IJournalBlobContainerFactory JournalBlobContainerFactory)
            :base(JournalBlobContainerFactory)
        {

        }

    }
    public class JCommodityBlobStorage : EntityBlobStorage<JCommodity>, IJCommodityBlobStorage
    {
        public JCommodityBlobStorage(IJCommodityBlobContainerFactory JCommodityBlobContainerFactory)
            :base(JCommodityBlobContainerFactory)
        {

        }
    }
    public class UserSettingJournalBlobStorage : EntityBlobStorage<UserSettingJournal>, IUserSettingJournalBlobStorage
    {
        public UserSettingJournalBlobStorage(IUserSettingJournalBlobContainerFactory UserSettingJournalBlobContainerFactory)
            :base(UserSettingJournalBlobContainerFactory)
        {

        }
    }
}
