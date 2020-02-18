using GesCMS.Core.Common;

namespace GesCMS.Core.Entities
{
    public class Widget : BaseEntity
    {
        public string Title { get; set; }
        public int? ParentID { get; set; }
    }
}
