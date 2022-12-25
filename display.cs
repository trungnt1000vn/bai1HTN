using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class display
    {
        private float size;
        private int colors;

        public float Size { get => size; set => size = value; }
        public int Colors { get => colors; set => colors = value; }

        public display(float size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }
        public display()
        {

        }
        public display(float size)
        {
            this.size = size;
        }
        public display(int colors)
        {
            this.colors = colors;
        }
    }
}
