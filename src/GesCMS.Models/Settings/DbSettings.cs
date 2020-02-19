using System;

namespace GesCMS.Models.Settings
{
    public class DbSettings
    {

        public string SqlConnection { get; set; }

        public TimeSpan ConnectionTimeOut { get; set; }        
        
    }
    
}