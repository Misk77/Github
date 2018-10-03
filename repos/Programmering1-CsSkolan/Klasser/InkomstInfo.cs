using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class InkomstInfo
    {
        public string name { get; set; }
        public int inkomst { get; set; }
        public int timmar { get; set; }

        public int Timlön { get { return inkomst / timmar; } }
       
           

        }
    }

