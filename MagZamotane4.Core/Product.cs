using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagZamotane4.Core
{
    public class Product
    {
        public int Identyfikator { get; set; }
        public string Nazwa { get; set; }
        public string Kod { get; set; }
        public string Cena { get; set; }
        public string CenaNetto { get; set; }
        public string CenaBrutto { get; set; }
        public string Vat { get; set; }
        public string Marza { get; set; }
        public string Wartosc { get; set; }
        public string Jednostka { get; set; }
        public string Ilosc { get; set; }
        public string NumFaktura { get; set; }
        public string DataFaktura { get; set; }
        public string Obrazek { get; set; }
        public string Inwentura { get; set; }

        public Product Clone()
        {
            Product obj = new Product();
            obj.Identyfikator = this.Identyfikator;
            obj.Kod = this.Kod;
            obj.Nazwa = this.Nazwa;
            obj.CenaNetto = this.CenaNetto;
            obj.Cena = this.Cena;
            obj.CenaBrutto = this.CenaBrutto;
            obj.Vat = this.Vat;
            obj.Marza = this.Marza;
            obj.Wartosc = this.Wartosc;
            obj.Jednostka = this.Jednostka;
            obj.Ilosc = this.Ilosc;
            obj.NumFaktura = this.NumFaktura;
            obj.DataFaktura = this.DataFaktura;
            obj.Obrazek = this.Obrazek;
            obj.Inwentura = this.Inwentura;
            return obj;
        }
        public void Copy(Product obj)
        {
            this.Identyfikator = obj.Identyfikator;
            this.Kod = obj.Kod;
            this.Nazwa = obj.Nazwa;
            this.CenaNetto = obj.CenaNetto;
            this.Cena = obj.Cena;
            this.CenaBrutto = obj.CenaBrutto;
            this.Vat = obj.Vat;
            this.Marza = obj.Marza;
            this.Wartosc = obj.Wartosc;
            this.Jednostka = obj.Jednostka;
            this.Ilosc = obj.Ilosc;
            this.NumFaktura = obj.NumFaktura;
            this.DataFaktura = obj.DataFaktura;
            this.Obrazek = obj.Obrazek;
            this.Inwentura = obj.Inwentura;
        }
    }
}
