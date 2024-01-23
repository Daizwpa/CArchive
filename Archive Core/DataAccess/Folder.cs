using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive_Core.DataAccess
{
    public  class Folder
    {
        public int ID { get; set; }
        public int Num_class { get; set; }
        public string Name_S { get; set; } = string.Empty;
        public string Name_B { get; set; } = string.Empty;
        public int Num_K { get; set; } 
        public int Num_S { get; set; }
        public int Num_R { get; set; }
        public int Num_B { get; set; }
        public string Name_Fo { get; set; } = string.Empty;
        public string BarCode_Fo { get => $"{Num_class}, {Num_K}, {Num_S}, {Num_R}, {Num_B}"; }
    }
}
