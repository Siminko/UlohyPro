using forest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forest
{
    class Ihlicnaty : Tree, IOrganizmus
    {
        public Ihlicnaty(double _radius, double _height)
        {
            radius = _radius;
            height = _height; 
        }
        ~Ihlicnaty()
        {

        }
        public override void Rastie()
        {
            throw new NotImplementedException();
        }
        public virtual double Obsah()
        {
            double Volume = Math.PI * radius * radius * height * (1.0 / 3.0);
            return Volume;
        } 

    }
}
