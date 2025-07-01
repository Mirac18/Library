using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi
{
    public class Admin
    {

        public Admin() { }
        public string AdminAdi { get; set; }

        List<Admin> Admins { get; set; } = new List<Admin>();


    }
}
