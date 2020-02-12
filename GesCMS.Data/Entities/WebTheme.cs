using System;
using System.Collections.Generic;
using System.Text;

namespace GesCMS.Data.Entities
{
    public class WebTheme
    {
        public int ID { get; set; }
        public string ThemeName { get; set; }
        public string ThemeRoot { get; set; }
        public bool IsActive { get; set; }
        public string ImageRoot { get; set; }
        public string Description { get; set; }
    }
}
