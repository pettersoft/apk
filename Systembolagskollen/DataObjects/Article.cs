using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Systembolagskollen.DataObjects;
using Systembolagskollen.Helpers;

namespace Systembolaget.DataObjects
{
	[Serializable, XmlRoot("artiklar")]
	public class Article
	{
		[XmlElement(ElementName = "skapad-tid")]
		public string CreatedAt { get; set; }

		[XmlElement(ElementName = "info")]
		public Extra Extra { get; set; }

		[XmlElement(ElementName = "artikel")]
		public Beverage[] Beverages { get; set; }

		public IEnumerable<Beverage> GetBeveragesFiltered(IEnumerable<Beverage> data, SearchModel searchModel)
		{
			var tempData = data;

			if (!string.IsNullOrEmpty(searchModel.ArticleNumberFrom))
				tempData = tempData.Where(c => c.ArticleNumber.ToLower().StartsWith(searchModel.ArticleNumberFrom.ToLower()));

			if (!string.IsNullOrEmpty(searchModel.ArticleNumberTo))
				tempData = tempData.Where(c => c.ArticleNumber.ToLower().EndsWith(searchModel.ArticleNumberTo.ToLower()));

			if (!string.IsNullOrEmpty(searchModel.Name))
				tempData = tempData.Where(x => x.Name.ToLower().Contains(searchModel.Name.ToLower()));

			if (searchModel.Koscher.HasValue)
				tempData = tempData.Where(x => IsValue1(x.Koscher) == searchModel.Koscher.Value);

			if (searchModel.Ethical.HasValue)
				tempData = tempData.Where(x => IsValue1(x.Ethical) == searchModel.Ethical.Value);

			if (searchModel.Ecologic.HasValue)
				tempData = tempData.Where(x => IsValue1(x.Ecologic) == searchModel.Ecologic.Value);

			if (searchModel.PriceFrom.HasValue && searchModel.PriceFrom.Value != 0)
				tempData = tempData.Where(x => x.PriceIncludingVat >= searchModel.PriceFrom.Value);

			if (searchModel.PriceTo.HasValue && searchModel.PriceTo.Value != 0)
				tempData = tempData.Where(x => x.PriceIncludingVat <= searchModel.PriceTo.Value);

			if (searchModel.AlcoholFrom.HasValue && searchModel.AlcoholFrom.Value != 0)
				tempData = tempData.Where(x => ConvertStringAlcoholToDecimal(x.Alcohol) >= searchModel.AlcoholFrom.Value);

			if (searchModel.AlcoholTo.HasValue && searchModel.AlcoholTo.Value != 0)
				tempData = tempData.Where(x => ConvertStringAlcoholToDecimal(x.Alcohol) <= searchModel.AlcoholTo.Value);

			if (!string.IsNullOrEmpty(searchModel.AlcoholType))
				tempData = tempData.Where(x => x.Department == searchModel.AlcoholType);

			//if (searchModel.SortByAPK)
			//	tempData = tempData.OrderByDescending(b => b.APK);
			IOrderedEnumerable<Beverage> order = tempData.OrderBy(a => 1);

			if (searchModel.SortByAPK)
				order = tempData.OrderByDescending(b => b.APK);

			if (searchModel.SortByArticleNumber)
				order.ThenBy(b => Convert.ToInt32(b.ArticleNumber));

			return order.ToList();
		}

		public string[] DrinkTypes(Beverage[] data)
		{
			var drinkTypes = data.Select(x => x.Department);
			var types = drinkTypes.Distinct();

			return types.OrderBy(c => c).ToArray();
		}

		public bool IsValue1(string s)
		{
			return s == "1";
		}

		public decimal ConvertStringAlcoholToDecimal(string s)
		{
			s = s.Remove(s.Length - 1, 1);
			if (s.Contains("."))
				s = s.Replace(".", ",");
			return Convert.ToDecimal(s);
		}
	}

	[Serializable]
	public class Extra
	{
		[XmlElement(ElementName = "meddelande")]
		public string Message { get; set; }
	}
}
