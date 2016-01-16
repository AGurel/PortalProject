using PortalProject.Core.Domain.Entity;
using System.Linq;

namespace PortalProject.Service.Settings
{
    public interface ISettingService
    {
        /// <summary>
        /// Get all settings.
        /// </summary>
        /// <returns></returns>
        IQueryable<Setting> GetAll();

        /// <summary>
        /// Find setting by id.
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        Setting Find(int settingId);

        /// <summary>
        /// Insert a new setting.
        /// </summary>
        /// <param name="setting"></param>
        void Insert(Setting setting);

        /// <summary>
        /// Update a setting.
        /// </summary>
        /// <param name="setting"></param>
        void Update(Setting setting);

        /// <summary>
        /// Delete a setting by setting.
        /// </summary>
        /// <param name="setting">Setting</param>
        void Delete(Setting setting);

        /// <summary>
        /// Delete a setting by setting id.
        /// </summary>
        /// <param name="settingId"></param>
        void Delete(int settingId);
    }
}
