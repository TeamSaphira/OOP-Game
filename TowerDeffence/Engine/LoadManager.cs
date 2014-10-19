namespace TowerDeffence.Engine
{
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class LoadManager
    {
        public static IEnumerable<XElement> LoadLevelDataXml(int level)
        {
            XDocument levelDocument = XDocument.Load(@"..\..\Files\levels.xml");

            var levelData = levelDocument.Descendants("Level" + level);

            return levelData;
        }
    }
}
