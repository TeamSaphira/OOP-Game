using System;
using System.Drawing;
using TowerDeffence.Helpers;

namespace TowerDeffence.Engine
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class LoadManager
    {
        private static LoadManager instance;

        private LoadManager()
        {
            
        }

        public static LoadManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoadManager();
                }
                return instance;
            }
        }

        public IEnumerable<EnemyData> LoadEnemyDataXml(int level)
        {
            XDocument levelDocument = XDocument.Load(@"..\..\Files\levels.xml");

            var levelData = levelDocument.Descendants("Level" + level);

            var enemies = levelData.Descendants("Enemy");

            var enemiesData = enemies.Select(enemy => new EnemyData
            {
                Count = int.Parse(enemy.Element("Count").Value),
                Bounty = int.Parse(enemy.Element("Bounty").Value),
                Health = int.Parse(enemy.Element("Health").Value),
                Size = enemy.Element("Size").Value,
                Speed = int.Parse(enemy.Element("Speed").Value),
                Type = enemy.Element("Type").Value,
            });

            if (levelData.Equals(null) || enemiesData.Count(el => !el.Equals(null)) == 0)
            {
                throw new ArgumentNullException(level.ToString());
            }

            return enemiesData;
        }

        public Image LoadImage(string path)
        {
            var img = new Bitmap(path);
            return img;
        }

        public Image LoadImage(string path, int width, int height)
        {
            var img = new Bitmap(path);
            var resizedImg = new Bitmap(img, width, height);

            return resizedImg;
        }
    }
}
