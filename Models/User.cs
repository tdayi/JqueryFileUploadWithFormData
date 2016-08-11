using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryFileUploadWithFormData.Models
{
    public class User
    {
        public HttpPostedFileBase File { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthPlace { get; set; }
    }
}