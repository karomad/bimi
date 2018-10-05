using BIMI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIMI.Web.Models
{
    public class ChooseserviceModel
    {
        public string Description { get; set; }
        public string MoneyRange { get; set; }
        public ServiceType ServiceType { get; set; }
    }

}
