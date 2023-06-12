using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210099_Proje
{
    class Domates : IAtik
    {  
        public int Hacim => 150;
        public Image Image=>Image.FromFile("Domates.png");
    }
}
