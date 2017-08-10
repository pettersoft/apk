using System;
using System.Windows.Forms;
using Systembolaget.DataObjects;

namespace Systembolagskollen
{
    public partial class BeverageInformation : Form
    {
        private Beverage[] Beverages;

        public BeverageInformation(Beverage[] beverages)
        {
            Beverages = beverages;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BeverageInformation_Load(object sender, EventArgs e)
        {
            bindingSourceForInformation.DataSource = Beverages;
            gridInformation.DataSource = bindingSourceForInformation;
            gridInformation.AllowUserToAddRows = false;
            gridInformation.AllowUserToDeleteRows = false;
            gridInformation.AllowUserToOrderColumns = false;
            gridInformation.EditMode = DataGridViewEditMode.EditProgrammatically;

            gridInformation.Columns.Clear();

            //Sätt om data i gridview så att kolumnerna blir på svenska
            gridInformation.Columns.Add("ArticleId", "Artikel id");
            gridInformation.Columns["ArticleId"].DataPropertyName = "ArticleId";

            gridInformation.Columns.Add("ArticleNumber", "Artikelnummer");
            gridInformation.Columns["ArticleNumber"].DataPropertyName = "ArticleNumber";

            gridInformation.Columns.Add("PartNumber", "Varunummer");
            gridInformation.Columns["PartNumber"].DataPropertyName = "PartNumber";

            gridInformation.Columns.Add("Name", "Benämning");
            gridInformation.Columns["Name"].DataPropertyName = "Name";

            gridInformation.Columns.Add("PriceIncludingVat", "Pris inkl. moms (kr)");
            gridInformation.Columns["PriceIncludingVat"].DataPropertyName = "PriceIncludingVat";

            gridInformation.Columns.Add("Pawn", "Pant (kr)");
            gridInformation.Columns["Pawn"].DataPropertyName = "Pawn";

            gridInformation.Columns.Add("VolumeInMl", "Volym i ML");
            gridInformation.Columns["VolumeInMl"].DataPropertyName = "VolumeInMl";

            gridInformation.Columns.Add("PricePerLiter", "Pris per liter");
            gridInformation.Columns["PricePerLiter"].DataPropertyName = "PricePerLiter";

            gridInformation.Columns.Add("StartOfSales", "Säljstart");
            gridInformation.Columns["StartOfSales"].DataPropertyName = "StartOfSales";

            gridInformation.Columns.Add("Department", "Varugrupp");
            gridInformation.Columns["Department"].DataPropertyName = "Department";

            gridInformation.Columns.Add("Packaging", "Förpackning");
            gridInformation.Columns["Packaging"].DataPropertyName = "Packaging";

            gridInformation.Columns.Add("CountryOfOrigin", "Ursprungsland");
            gridInformation.Columns["CountryOfOrigin"].DataPropertyName = "CountryOfOrigin";

            gridInformation.Columns.Add("Producer", "Producent");
            gridInformation.Columns["Producer"].DataPropertyName = "Producer";

            gridInformation.Columns.Add("Supplier", "Leverantör");
            gridInformation.Columns["Supplier"].DataPropertyName = "Supplier";

            gridInformation.Columns.Add("Alcohol", "Alkoholhalt");
            gridInformation.Columns["Alcohol"].DataPropertyName = "Alcohol";

            gridInformation.Columns.Add("Assortment", "Sortiment");
            gridInformation.Columns["Assortment"].DataPropertyName = "Assortment";

            gridInformation.Columns.Add("EcologicSynopsis", "Ekologiskt");
            gridInformation.Columns["EcologicSynopsis"].DataPropertyName = "EcologicSynopsis";

            gridInformation.Columns.Add("EthicalSynopsis", "Etiskt");
            gridInformation.Columns["EthicalSynopsis"].DataPropertyName = "EthicalSynopsis";

            gridInformation.Columns.Add("KoscherSynopsis", "Koscher");
            gridInformation.Columns["KoscherSynopsis"].DataPropertyName = "KoscherSynopsis";
            
            gridInformation.Refresh();
        }

        /// <summary>
        /// Stäng ner fönstret
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
