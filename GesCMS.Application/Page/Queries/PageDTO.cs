using GesCMS.Application.Common.Mappings;
using GesCMS.Core;
using System.Collections.Generic;

namespace GesCMS.Application.Page.Queries
{
    public class PageDTO : IMapFrom<Core.Entities.Page>
    {
        public PageDTO()
        {
            WidgetsInPage = new List<WidgetsInPageDTO>();
        }

        public int ID { get; set; }
        public string PageTitle { get; set; }
        public virtual List<WidgetsInPageDTO> WidgetsInPage { get; set; }
        public virtual PageDTO ParentPage { get; set; }
        public string Route { get; set; }
        public bool IsHomePage { get; set; }
    }
}
