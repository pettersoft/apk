using System;
using System.IO;
using System.Xml.Serialization;
using Systembolaget.DataObjects;
using System.Text;

namespace Systembolagskollen
{
    public class XmlLoader
    {
        /// <summary>
        /// Laddar in en Article från XML Fil
        /// </summary>
        /// <returns></returns>
        public Article LoadArticleFromXml()
        {
            try {
                if (!File.Exists("sortiment.xml"))
                {
                    AlertHelper.AlertHelper.Alert("Ingen sortimentfil finns nedladdad. Vänligen ladda ned en sortimentfil genom att gå in på Arkiv > Uppdatera.");
                    return null;
                }
                        
                var file = File.ReadAllText("sortiment.xml", Encoding.UTF8);

                var serializer = new XmlSerializer(typeof(Article));
                var article = (Article)serializer.Deserialize(new StringReader(file));

                return article;
            } catch (Exception e)
            {
                Logger.Write(e);
                throw;
            }
        }
    }
}
