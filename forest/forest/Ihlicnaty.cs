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
        public Ihlicnaty()
        {

        }
        ~Ihlicnaty()
        {

        }
        public void Rastie()
        {
            throw new NotImplementedException();
        }
        public virtual double Obsah()
        {
            Volume = Math.PI * radius * radius * height * (1.0 / 3.0);
            return Volume;
        } 

    }
}
