using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BIMI.Web.Models
{
    public class JobModel
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public string Description { get; set; }
        public string MoneyRange { get; set; }
        public int Type { get; set; }
        public bool isParent { get; set; }
       
        public ApplicationUser User { get; set; }
    }
}