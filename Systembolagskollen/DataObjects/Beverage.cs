using System;
using System.Xml;
using System.Xml.Serialization;
using Systembolagskollen.Helpers;

namespace Systembolaget.DataObjects
{
    [Serializable]
    public class Beverage
    {
        [XmlElement("nr")]
        public string ArticleNumber { get; set; }

        [XmlElement("Artikelid")]
        public string ArticleId { get; set; }

        [XmlElement("Varnummer")]
        public string PartNumber { get; set; }

        [XmlElement("Namn")]
        public string Name { get; set; }

        [XmlElement("Prisinklmoms")]
        public decimal PriceIncludingVat { get; set; }

        [XmlElement("Pant")]
        public string Pawn { get; set; }

        [XmlElement("Volymiml")]
        public decimal VolumeInMl { get; set; }

        [XmlElement("PrisPerLiter")]
        public decimal PricePerLiter { get; set; }

        [XmlElement("Saljstart")]
        public string StartOfSales { get; set; }

        [XmlElement("Varugrupp")]
        public string Department { get; set; }

        [XmlElement("Forpackning")]
        public string Packaging { get; set; }

        [XmlElement("Ursprunglandnamn")]
        public string CountryOfOrigin { get; set; }

        [XmlElement("Producent")]
        public string Producer { get; set; }

        [XmlElement("Leverantor")]
        public string Supplier { get; set; }

        [XmlElement("Alkoholhalt")]
        public string Alcohol { get; set; }

        [XmlElement("Sortiment")]
        public string Assortment { get; set; }

        [XmlElement("Ekologiskt")]
        public string Ecologic { get; set; }

        [XmlElement("Etiskt")]
        public string Ethical { get; set; }

        [XmlElement("Koscher")]
        public string Koscher { get; set; }

        [XmlElement("RavarorBeskrivning")]
        public string RawMaterialSynopsis { get; set; }

        public string EcologicSynopsis
        {
            get
            {
                if (EcologicAsBool)
                    return "Ja";
                return "Nej";
            }
        }

        public string EthicalSynopsis
        {
            get
            {
                if (EthicalAsBool)
                    return "Ja";
                return "Nej";
            }
        }

        public string KoscherSynopsis
        {
            get
            {
                if (KoscherAsBool)
                    return "Ja";
                return "Nej";
            }
        }

        private bool EcologicAsBool
        {
            get
            {
                return Ecologic == "1";
            }
        }

        private bool EthicalAsBool
        {
            get
            {
                return Ethical == "1";
            }
        }

        private bool KoscherAsBool
        {
            get
            {
                return Koscher == "1";
            }
        }

        public decimal PriceIncludingPawn
        {
            get
            {
                if (Pawn == null)
                    return PriceIncludingVat;
                return (PriceIncludingVat + Convert.ToDecimal(Pawn.Replace(".", ",")));
            }
        }

        public override string ToString()
        {
            var stringLiteral = "";

            stringLiteral += String.Format("{0, -50}", Name);
            stringLiteral += String.Format("{0, 10}", ArticleId);
            stringLiteral += String.Format("{0, 20}", ArticleNumber);
            stringLiteral += String.Format("{0, 100}", PriceIncludingVat);
            stringLiteral += String.Format("{0, 20}", PartNumber);

            return stringLiteral;
        }

        public decimal APK
        {
            get
            {
                var volume = VolumeInMl;
                var percentage = this.AlcoholToDecimal().PreventZero().ToPercentage();
                var price = PriceIncludingVat.PreventZero();

                var täljare = VolumeInMl * percentage;
                var nämnare = price;

                var apk = täljare / nämnare;

                return Math.Round(apk, 2);
            }
        }
    }
}
