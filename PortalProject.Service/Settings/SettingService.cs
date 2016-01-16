using PortalProject.Core.Domain.Entity;
using PortalProject.Data.Repository;
using PortalProject.Data.UnitOfWork;
using System.Linq;

namespace PortalProject.Service.Settings
{
    public class SettingService : ISettingService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Setting> _settingRepository;

        public SettingService(IUnitOfWork uow)
        {
            _uow = uow;
            _settingRepository = uow.GetRepository<Setting>();
        }

        /// <summary>
        /// Get all settings.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Setting> GetAll()
        {
            return _settingRepository.GetAll();
        }
        
        /// <summary>
        /// Find setting by setting id
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        public Setting Find(int settingId)
        {
            return _settingRepository.Find(settingId);
        }

        /// <summary>
        /// Insert new setting.
        /// </summary>
        /// <param name="setting"></param>
        public void Insert(Setting setting)
        {
            _settingRepository.Insert(setting);
        }

        /// <summary>
        /// Update a setting.
        /// </summary>
        /// <param name="setting"></param>
        public void Update(Setting setting)
        {
            _settingRepository.Update(setting);
        }

        /// <summary>
        /// Delete a setting by setting entity.
        /// </summary>
        /// <param name="setting">Setting</param>
        public void Delete(Setting setting)
        {
            _settingRepository.Delete(setting);
        }

        /// <summary>
        /// Delete a setting by setting id.
        /// </summary>
        /// <param name="settingId">Setting Id</param>
        public void Delete(int settingId)
        {
            _settingRepository.Delete(settingId);
        }
    }
}
