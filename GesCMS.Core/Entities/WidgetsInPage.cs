using GesCMS.Core.Common;

namespace GesCMS.Core.Entities
{
    public class WidgetsInPage : BaseEntity
    {
        public virtual Widget Widget { get; set; }
        public virtual WidgetValue WidgetValue { get; set; }
        public virtual Page Page { get; set; }
        public virtual WidgetInPagePriority WidgetInPagePriority { get; set; }
    }
}
