using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive_Core.DataAccess
{
    public class File
    {
        public int ID { get; set; }
        public int Num_F { get; set; }
        public string Type_F { get; set; } = string.Empty;
        public DateTime Date_F { get; set; }
        public string Class_F { get; set; } = string.Empty;
        public string Object { get; set; } = string.Empty;
        public int Num_p { get; set; }
        public string Save_Max { get; set; } = string.Empty;
        public string Save_Min { get; set; } = string.Empty;
        public string Phy_Codt { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string Url_F { get; set; } = string.Empty;

        public User? user { get; set; }
        public Folder? folder { get; set; } 
    }
}
