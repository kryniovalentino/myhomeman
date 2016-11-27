using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeManager
{
    class Home
    {
        public int HomeID { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        //public TYPE Type { get; set; }
    }
}
