using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class Experience
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Position { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public string ImageURL { get; set; }
    }
}