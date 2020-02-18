using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Widget : AuditableEntity
    {
        public string Title { get; set; }
        public int? ParentID { get; set; }
    }
}
