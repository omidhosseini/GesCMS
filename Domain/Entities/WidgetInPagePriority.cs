using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class WidgetInPagePriority : AuditableEntity
    {
        public byte Priority { get; set; }
    }
}
