using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Entities
{
    abstract class Shapee
    {
        public Color Color { get; set; } 

     
        public Shapee(Color color)
        {
            Color = color;
        }
        public abstract double Area();
       
    }

}