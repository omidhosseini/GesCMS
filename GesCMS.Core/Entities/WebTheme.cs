using GesCMS.Core.Common;

namespace GesCMS.Core.Entities
{
    public class WebTheme : BaseEntity
    {
        public string ThemeName { get; set; }
        public string ThemeRoot { get; set; }
        public bool IsActive { get; set; }
        public string ImageRoot { get; set; }
        public string Description { get; set; }
    }
}
