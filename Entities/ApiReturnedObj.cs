using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyPWAArtmedia.Entities
{
    public class ApiReturnedObj
    {
        public bool success { get; set; }
        public string errormessage { get; set; }
        public int errorcode { get; set; }
        public string uidoperazione { get; set; }
        public int pagecount { get; set; }

        //[JsonConverter(typeof(InfoToStringConverter))]
        public object obj;

        public int versioneprogramma { get; set; }
        public int sottoversioneprogramma { get; set; }
    }
    
}
