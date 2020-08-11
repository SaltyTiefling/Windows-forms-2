using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef01
{
    class Notitie
    {
        DateTime dateAndTime = DateTime.Now;
        public string naam;
        public string opschrift;

        public Notitie(string naam, string opschrift)
        {
            this.naam = naam;
            this.opschrift = opschrift;
        }

        public Notitie(string opschrift)
        {
            this.opschrift = opschrift;
        }
        public override string ToString()
        {
            return naam;
        }
    }
}
