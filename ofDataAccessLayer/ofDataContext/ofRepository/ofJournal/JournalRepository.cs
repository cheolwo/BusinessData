using System;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofJournal.ofRepository
{
    public interface IJournalCenterRepository : ICenterDataRepository<JournalCenter>
    {

    }
    public interface IJCommodityRepository : ICommodityDataRepository<JCommodity>
    {

    }
    public interface IJournalRepository : IEntityDataRepository<Journal>
    {

    }
    public interface IUserSettingJournalRepository : IEntityDataRepository<UserSettingJournal>
    {

    }
    public class JournalCenterRepository : CenterDataRepository<JournalCenter>, IJournalCenterRepository
    {
        public JournalCenterRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
        public JournalCenterRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
    public class JCommodityRepository : CommodityDataRepository<JCommodity>, IJCommodityRepository
    {
        public JCommodityRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
        public JCommodityRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
    public class UserSettingJournalRepository : EntityDataRepository<UserSettingJournal>
    {
        public UserSettingJournalRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
        public UserSettingJournalRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
        public async Task<UserSettingJournal> GetByEntityName(string entityTypeName)
        {
            return await _DbContext.Set<UserSettingJournal>().FirstOrDefaultAsync(e=>e.EntityTypeName.Equals(entityTypeName));
        }
    }
    public class JournalRepository : EntityDataRepository<Journal>, IJournalRepository
    {
        public JournalRepository(JournalDbContext JournalDbContext)
            :base(JournalDbContext)
        {

        }
        public JournalRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
}
