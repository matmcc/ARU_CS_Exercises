using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARU_CS_Exercises
{
    class PaintWindow
    {
        public double width { get; set; }
        public double height { get; set; }
        public double area { get; set; }

        public PaintWindow(double w, double h)
        {
            width = w;
            height = h;
            area = w * h;
        }
    }
}
