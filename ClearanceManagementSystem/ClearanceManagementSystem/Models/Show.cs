using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClearanceManagementSystem.Models
{
    public class Show
    {

        public int ID_Student { get; set; }

        public int ID_User { get; set; }
        
        public string Notes { get; set; }

        public bool Status { get; set; }
       
        public string Name_Office { get; set; }
    }
}