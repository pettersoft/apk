using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Systembolaget.DataObjects;
using Systembolagskollen.DataObjects;

/// <summary>
/// Petter Pettersson
/// 2016-06-05
/// </summary>
namespace Systembolagskollen
{
	public partial class MainForm : Form
	{
		private int _totalPages;
		private int _currentPage = 0;
		private int _itemsPerPage = 50;
		private int _amountOfArticles = 0;
		private Article Article;
		private SearchModel SearchModel;
		private Beverage[] FilteredBeverages { get; set; }

		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// När projektet laddas vill vi läsa in XML-filen direkt så den finns i minnet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			Reload();
		}

		private void Reload()
		{
			var xmlLoader = new XmlLoader();
			SearchModel = new SearchModel();
			Article = xmlLoader.LoadArticleFromXml();

			if (Article == null)
				return;

			SetDataSource();
			SetAlcoholTypes();
			RefreshDataSource();

			UpdateAmountOfArticles();
		}

		void UpdateAmountOfArticles()
		{
			_amountOfArticles = FilteredBeverages?.Length ?? 0;
			tsLblAmountOfArticles.Text = $"Antal artiklar: {_amountOfArticles}";
		}

		/// <summary>
		/// Sätter om alkoholtyper i listan
		/// </summary>
		private void SetAlcoholTypes()
		{
			cBoxTypes.Items.Clear();

			var drinkTypes = Article.DrinkTypes(Article.Beverages);
			cBoxTypes.Items.Add("Inget val");
			cBoxTypes.Items.AddRange(drinkTypes);
			cBoxTypes.SelectedIndex = 0;
		}

		/// <summary>
		/// Laddar om datakällan och sätter om grid viewens fält
		/// </summary>
		private void RefreshDataSource()
		{
			FilteredBeverages = Article.GetBeveragesFiltered(Article.Beverages, SearchModel).ToArray();
			beverageDataSource.DataSource = FilteredBeverages.Skip(_currentPage * _itemsPerPage).Take(_itemsPerPage);
			beverageGridView.Columns.Clear();

			_totalPages = (int)Math.Ceiling(Convert.ToDecimal(FilteredBeverages.Count()) / Convert.ToDecimal(_itemsPerPage));
			txtPage.Text = $"{_currentPage + 1}";
			tsLblPages.Visible = true;
			tsLblPages.Text = $"Sida {_currentPage + 1}/{_totalPages}";

			beverageGridView.AllowUserToResizeRows = false;
			beverageGridView.AllowUserToResizeColumns = false;
			beverageGridView.AllowUserToOrderColumns = false;

			beverageGridView.Columns.Add("PartNumber", "Varunummer");
			beverageGridView.Columns["PartNumber"].DataPropertyName = "PartNumber";

			beverageGridView.Columns.Add("Name", "Benämning");
			beverageGridView.Columns["Name"].DataPropertyName = "Name";

			beverageGridView.Columns.Add("Alcohol", "Alkoholhalt");
			beverageGridView.Columns["Alcohol"].DataPropertyName = "Alcohol";

			beverageGridView.Columns.Add("APK", "APK");
			beverageGridView.Columns["APK"].DataPropertyName = "APK";

			beverageGridView.Columns.Add("PriceIncludingVat", "Pris inkl. moms (kr)");
			beverageGridView.Columns["PriceIncludingVat"].DataPropertyName = "PriceIncludingVat";

			beverageGridView.Columns.Add("VolumeInMl", "Volym (ML)");
			beverageGridView.Columns["VolumeInMl"].DataPropertyName = "VolumeInMl";

			beverageGridView.Columns.Add("Department", "Varugrupp");
			beverageGridView.Columns["Department"].DataPropertyName = "Department";

			var rowCount = beverageGridView.Rows.Count;
			var cellStyle = new DataGridViewCellStyle
			{
				BackColor = System.Drawing.Color.GhostWhite
			};

			// Vill inte färga om första
			for (var i = 1; i < rowCount; i++)
			{
				if (i % 2 == 0)
					continue;

				beverageGridView.Rows[i].DefaultCellStyle = cellStyle;
			}

			beverageGridView.Refresh();
		}

		private void SetDataSource()
		{
			_totalPages = (int)Math.Ceiling(Convert.ToDecimal(Article.Beverages.Count()) / Convert.ToDecimal(_itemsPerPage));

			beverageDataSource.DataSource = Article.Beverages.Skip(_currentPage * _itemsPerPage).Take(_itemsPerPage);

			beverageGridView.DataSource = beverageDataSource;
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			SetPage(true);
		}

		/// <summary>
		/// Paginering
		/// </summary>
		/// <param name="goForward"></param>
		private void SetPage(bool goForward)
		{
			if (goForward && _currentPage < (_totalPages - 1))
				_currentPage++;

			if (!goForward && _currentPage > 0)
				_currentPage--;

			RefreshDataSource();
		}

		/// <summary>
		/// Bakåt
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPrevious_Click(object sender, EventArgs e)
		{
			SetPage(false);
		}

		/// <summary>
		/// Framåt
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			SetSearchModel();
			RefreshDataSource();
			UpdateAmountOfArticles();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ResetSearchForm();
			SetSearchModel();
			RefreshDataSource();
			UpdateAmountOfArticles();
		}

		/// <summary>
		/// Återställer formuläret
		/// </summary>
		private void ResetSearchForm()
		{
			txtArticleNumberFrom.Text = string.Empty;
			txtArticleNumberTo.Text = string.Empty;
			txtName.Text = string.Empty;
			checkEco.Checked = false;
			checkKoscher.Checked = false;
			checkEthical.Checked = false;
			cBoxAPK.Checked = false;
			txtPriceFrom.Text = (0m).ToString();
			txtPriceTo.Text = (0m).ToString();
			txtAlcoholFrom.Text = (0m).ToString();
			txtAlcoholTo.Text = (0m).ToString();
			cBoxTypes.SelectedIndex = 0;
			cBoxSortByArticleNumber.Checked = false;
		}

		/// <summary>
		/// Sätter om sökmodellen beroende på värden som angivits
		/// </summary>
		/// <param name="clear"></param>
		private void SetSearchModel()
		{
			_currentPage = 0;
			try
			{
				SearchModel.ArticleNumberFrom = txtArticleNumberFrom.Text;
				SearchModel.ArticleNumberTo = txtArticleNumberTo.Text;
				SearchModel.Ecologic = checkEco.Checked;
				SearchModel.Koscher = checkKoscher.Checked;
				SearchModel.Ethical = checkEthical.Checked;
				SearchModel.PriceFrom = Convert.ToDecimal(txtPriceFrom.Text);
				SearchModel.PriceTo = Convert.ToDecimal(txtPriceTo.Text);
				SearchModel.Name = txtName.Text;
				SearchModel.AlcoholFrom = Convert.ToDecimal(txtAlcoholFrom.Text);
				SearchModel.AlcoholTo = Convert.ToDecimal(txtAlcoholTo.Text);
				SearchModel.SortByAPK = cBoxAPK.Checked;
				SearchModel.SortByArticleNumber = cBoxSortByArticleNumber.Checked;

				if (cBoxTypes.SelectedIndex > 0)
					SearchModel.AlcoholType = cBoxTypes.SelectedItem.ToString();
				else
					SearchModel.AlcoholType = "";

			}
			catch (Exception e)
			{
				AlertHelper.AlertHelper.Alert("Någonting gick snett, " + e.Message);
			}
		}

		private void gBoxFilter_Enter(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Om man klickar på en cell i gridview vill vi att det ska gå att använda öppna artikel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beverageGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SetStateForOpenButton();
		}

		/// <summary>
		/// Stäng programmet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Öppna artikel klick event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOpen_Click(object sender, EventArgs e)
		{
			openBeverageInformation();
		}

		/// <summary>
		/// Öppnar upp BeverageInformation rutan
		/// </summary>
		private void openBeverageInformation()
		{
			if (beverageGridView.SelectedRows.Count == 0)
				return;

			var items = new Beverage[beverageGridView.SelectedRows.Count];
			for (var i = 0; i < beverageGridView.SelectedRows.Count; i++)
			{
				items[i] = beverageGridView.SelectedRows[i].DataBoundItem as Beverage;
			}

			var beverageInformation = new BeverageInformation(items);
			beverageInformation.ShowDialog();
		}

		/// <summary>
		/// Klick event för om programmet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void omProgrammetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var aboutBox = new AboutBeverageInformation();
			aboutBox.ShowDialog();
		}

		private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
		{
			pgBarDownload.Style = ProgressBarStyle.Blocks;
			pgBarDownload.Step = 100;
			pgBarDownload.PerformStep();
			Reload();
		}


		private void DownloadProgressCallback(Object sender, DownloadProgressChangedEventArgs e)
		{
			lblBytesReceived.Text = $"Hämtat {e.BytesReceived / 1000} kb";
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var webClient = new WebClient();
			var uri = new Uri("https://www.systembolaget.se/api/assortment/products/xml");

			pgBarDownload.Visible = true;
			pgBarDownload.Style = ProgressBarStyle.Marquee;

			webClient.DownloadFileAsync(uri, "sortiment.xml");
			webClient.DownloadProgressChanged += DownloadProgressCallback;
			webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
		}

		private void beverageGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			SetStateForOpenButton();
		}

		void SetStateForOpenButton()
		{
			btnOpen.Enabled = false;
			if (beverageGridView.SelectedRows.Count > 0)
				btnOpen.Enabled = true;
		}

		private void txtPage_Leave(object sender, EventArgs e)
		{
			SetPage();
		}

		void SetPage()
		{
			if (!int.TryParse(txtPage.Text, out var page))
			{
				AlertHelper.AlertHelper.Alert($"Kunde ej läsa {txtPage.Text} som siffra");
				return;
			}

			// -1 eftersom vi har lurat användaren
			_currentPage = page - 1;
			RefreshDataSource();
		}
	}
}
