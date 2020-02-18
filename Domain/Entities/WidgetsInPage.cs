using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class WidgetsInPage : AuditableEntity
    {
        public virtual Widget Widget { get; set; }
        public virtual WidgetValue WidgetValue { get; set; }
        public virtual Page Page { get; set; }
        public virtual WidgetInPagePriority WidgetInPagePriority { get; set; }
    }
}
