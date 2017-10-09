using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARU_CS_Exercises
{
    class Paint
    {
        public int _FeetPerGallon { get; set; } = 100;
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        private PaintWindow[] windows = null;
        
        public Paint(int l, int w, int h, int numWindows)
        {
            Length = l;
            Width = w;
            Height = h;
            windows = new PaintWindow[numWindows];
            for (int i = 0; i < numWindows; i++)
            {
                Console.WriteLine($"Width of window {i+1}?");
                double _w = double.Parse(Console.ReadLine());
                Console.WriteLine($"Height of window {i+1}?");
                double _h = double.Parse(Console.ReadLine());
                windows[i] = new PaintWindow(_w, _h);
            }
        }

        public int GetNumTins()
        {
            int areaIgnoreWindows = (2 * Length * Height) + (2 * Width * Height) + (Length * Width);
            double areaWindows = 0;
            foreach (PaintWindow window in windows)
            {
                areaWindows += window.area;
            }
            double area = areaIgnoreWindows - areaWindows;
            var numTins = Math.Ceiling(area / _FeetPerGallon);
            return (int)numTins;
        }


    }
}
