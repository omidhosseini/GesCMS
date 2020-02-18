using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class WidgetValue : AuditableEntity
    {
        public string Value { get; set; }
    }
}
