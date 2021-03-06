﻿namespace TowerDeffence.Engine
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    using Helpers.Data;

    public class LoadManager
    {
        private static LoadManager instance;
        private const string MapPath = @"..\..\Files\map.csv";

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

            var loadEnemyDataXml = enemiesData as IList<EnemyData> ?? enemiesData.ToList();
            if (levelData.Equals(null) || loadEnemyDataXml.Count(el => !el.Equals(null)) == 0)
            {
                throw new ArgumentNullException(level.ToString());
            }

            return loadEnemyDataXml;
        }

        public IEnumerable<TurretData> LoadTurretDataXml()
        {
            XDocument levelDocument = XDocument.Load(@"..\..\Files\turrets.xml");

            var levelData = levelDocument.Descendants("Turrets");

            var turrets = levelData.Descendants("Turret");

            var turretsData = turrets.Select(enemy => new TurretData()
            {
                Type = enemy.Element("Type").Value,
                Damage = double.Parse(enemy.Element("Damage").Value),
                FireRate = double.Parse(enemy.Element("FireRate").Value),
                Price = int.Parse(enemy.Element("Price").Value),
                Range = int.Parse(enemy.Element("Range").Value),
            });

            var loadTurretDataXml = turretsData as IList<TurretData> ?? turretsData.ToList();
            if (levelData.Equals(null) || loadTurretDataXml.Count(el => !el.Equals(null)) == 0)
            {
                throw new FormatException("Can`t parse turret data");
            }

            return loadTurretDataXml;
        }

        public List<List<byte>> FillMapFromFile()
        {
            var mapMatrix = new List<List<byte>>();

            
            string input = File.ReadAllText(MapPath);
            string[] inputLines = input.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in inputLines)
            {
                string[] lineParts = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                var row = lineParts.Select(byte.Parse).ToList();
                mapMatrix.Add(row);
            }

            return mapMatrix;
        }

        public string ReadAllText(string path)
        {
            string fileContent = File.ReadAllText(path);

            return fileContent;
        }
    }
}
