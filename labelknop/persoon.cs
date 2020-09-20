using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labelknop
{
    public class persoon
    {
        public string Voornaam;
        public string Achternaam;
        public int LeefTijd;

        public persoon(string voornaam, string achternaam, int leefTijd)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            LeefTijd = leefTijd;
        }
        public string Bekijken()
        {
            string bechrijving = "";
            bechrijving = $"AchterNaam :{ Achternaam}" + " " +$"LeefTijd{LeefTijd}";
            return bechrijving;
        }
        public override string ToString()
        {
            return Voornaam;
        }
    }
}
