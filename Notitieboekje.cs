using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef01
{
    class Notitieboekje
    {
        public string eigenaar { get; set; }
        public string titel { get; set; }
        public string kleur { get; set; }
        public List<Notitie> notities { get; set; }

        public Notitieboekje()
        {
            notities = new List<Notitie>();
        }
        public Notitieboekje(string eigenaar, string titel, string kleur)
        {

        }

        public void Bijschrijven(string notitie)
        {
            Notitie newNotitie = new Notitie(notitie);
            notities.Add(newNotitie);
        }
        public void Bijschrijven(string naam,string notitie)
        {

            Notitie newNotitie = new Notitie(naam, notitie);
            notities.Add(newNotitie);
        }
        public void Uitscheuren(string teVerwijderenNotitie)
        {

            for (int i = 0; i < notities.Count; i++)
            {
                if (notities[i].naam.Equals(teVerwijderenNotitie))
                {
                    notities.Remove(notities[i]);
                }
            }

        }
        public Notitie BekijkNotitie(int index)
        {
            return notities[index];
        }
        public List<Notitie> BekijkNotities()
        {
            return notities;

        }
        public void VulNotitieAan(string naam, string bijschrift)
        {
            foreach (var item in notities)
            {
                if (item.naam.Equals(naam))
                {
                    if (!item.opschrift.Equals(""))
                    {
                        item.opschrift += "\n";
                    }
                    item.opschrift += bijschrift;
                }
            }
        }

    }
}
