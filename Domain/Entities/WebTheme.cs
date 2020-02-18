using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class WebTheme : AuditableEntity
    {
        public string ThemeName { get; set; }
        public string ThemeRoot { get; set; }
        public bool IsActive { get; set; }
        public string ImageRoot { get; set; }
        public string Description { get; set; }
    }
}
