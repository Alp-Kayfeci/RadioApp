using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public bool PremiumStatus { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
