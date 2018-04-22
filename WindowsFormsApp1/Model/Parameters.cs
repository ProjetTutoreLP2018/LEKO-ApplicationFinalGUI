using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettreCooperation
{
    public class Parameters
    {
        public List<string> dataset { get; set; }
        public string timezone { get; set; }
        public string q { get; set; }
        public int rows { get; set; }
        public string format { get; set; }
        public List<string> facet { get; set; }
    }
}
