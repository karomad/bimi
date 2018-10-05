using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIMI.Web.Models
{
    public class MainPageViewModel
    {
        public List<JobModel> Jobs { get; set; }
        public List<ApplicationUser> agents { get; set; }
    }
}