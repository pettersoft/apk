namespace Systembolagskollen.DataObjects
{
    public class SearchModel
    {
        public string ArticleNumberTo { get; set; }
        public string ArticleNumberFrom { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        public bool? Ecologic { get; set; }
        public bool? Koscher { get; set; }
        public bool? Ethical { get; set; }
        public string Name { get; set; }
        public decimal? AlcoholFrom { get; set; }
        public decimal? AlcoholTo { get; set; }
        public string AlcoholType { get; set; }
        public bool SortByAPK { get; set; }
		public bool SortByArticleNumber { get; set; }
    }
}
