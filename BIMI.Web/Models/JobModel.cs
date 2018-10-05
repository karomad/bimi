using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIMI.Web.Models
{
    public class JobModel
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string MoneyRange { get; set; }
        public int Type { get; set; }
        public bool isParent { get; set; }
    }
}