using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class Education
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
    }
}