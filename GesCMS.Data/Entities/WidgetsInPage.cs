using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GesCMS.Data.Entities
{
    public class WidgetsInPage
    {
        public int ID { get; set; }
        public virtual Widget Widget { get; set; }
        public virtual WidgetValue WidgetValue { get; set; }
        public virtual Page Page { get; set; }
        public virtual WidgetInPagePriority WidgetInPagePriority { get; set; }
    }
}
