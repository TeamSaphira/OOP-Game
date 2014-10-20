using System;
using System.Drawing;

namespace TowerDeffence.Engine
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class LoadManager
    {
        public static IEnumerable<object> LoadLevelDataXml(int level)
        {
            XDocument levelDocument = XDocument.Load(@"..\..\Files\levels.xml");

            var levelData = levelDocument.Descendants("Level" + level);

            var enemies = levelData.Descendants("Enemy");

            var enemiesData = from enemy in enemies
                              select new
                              {
                                  Count = enemy.Element("Count").Value,
                                  Size = enemy.Element("Size").Value,
                                  Health = enemy.Element("Health").Value,
                                  Price = enemy.Element("Price").Value,
                                  Speed = enemy.Element("Speed").Value
                              };

            if (levelData.Equals(null))
            {
                throw new ArgumentNullException(enemiesData.ToString());
            }

            return enemiesData;
        }

        public static Image LoadImage(string path)
        {
            // load image

            return new Bitmap(1,1);
        }
    }
}
