namespace TowerDeffenceTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TowerDeffence.Engine;

    [TestClass]
    public class DataLoaderTests
    {
        [TestMethod]
        public void LoadLevel1Data()
        {
            var data = LoadManager.LoadLevelDataXml(1);
            Assert.AreSame(new object(), data);
        }
    }
}
