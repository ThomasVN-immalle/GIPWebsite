using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{


    public class Klant
    {
        private int _KlantId;
        private String _Voornaam;
        private string _Familienaam;
        private string _Geboortedatum;
        private string _Emailadres;
        private string _Factuurdatum;
        private int _AbonnementID;

        public Klant(int KlantId,String Voornaam, String Achternaam, string Geboortedatum, string Emailadres, string Factuurdatum)
        {
            _KlantId = KlantId;
            _Voornaam = Voornaam;
            _Familienaam = Familienaam;
            _Geboortedatum = Geboortedatum;
            _Emailadres = Emailadres;
            _Factuurdatum = Factuurdatum;
        }

        public int KlantId
        {
            get { return _KlantId; }
            set { _KlantId = value; }
        }

        public String Voornaam
        {
            get { return _Voornaam; }
            set { _Voornaam = value; }
        }

        public String Familienaam
        {
            get { return _Familienaam; }
            set { _Familienaam = value; }
        }

        public string Geboortedatum
        {
            get { return _Geboortedatum; }
            set { _Geboortedatum = value; }
        }

        public string Emailadres
        {
            get { return _Emailadres; }
            set { _Emailadres = value; }
        }

        public string Factuurdatum
        {
            get { return _Factuurdatum; }
            set { _Factuurdatum = value; }
        }

        public int AbonnementID
        {
            get { return _AbonnementID; }
            set { _AbonnementID = value; }
        }



        public override string ToString()
        {
            return _Voornaam + _Familienaam + _Geboortedatum.ToString() + _Emailadres + _Factuurdatum;

        }
    }
}
