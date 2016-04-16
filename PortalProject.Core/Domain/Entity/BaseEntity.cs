
using PortalProject.Core.Enums.Common;
namespace PortalProject.Core.Domain.Entity
{
    /// <summary>
    ///  All entities get inheritance from this.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public RecordLocation Location { get; set; }
        public Language Language { get; set; }
    }
}
