using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forest
{
    class Baubab : Tree
    {
        public Baubab(double _radius, double _height)
        {
            radius = _radius;
            height = _height;
        }
        ~Baubab()
        {

        }
        public virtual double Obsah()
        {
            double Volume = Math.PI * radius * radius * height;
            return Volume;
        } 


    }
}
