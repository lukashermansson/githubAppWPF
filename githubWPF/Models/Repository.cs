using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubWPF.Models
{
    public class Repository
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Language { get; set; }
        public DateTime Updated_At { get; set; }
    }
}
