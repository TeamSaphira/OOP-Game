namespace TowerDeffence.Interfaces
{
    using GameObjects;

    public interface IBattleUnit
    {
        UnitSize Size { get; }

        int Health { get; }

        int Price { get; }

        //int SellPrice { get; }
    }
}
