namespace TowerDeffence.GameObjects
{
    using Interfaces;
    using Helpers;

    public abstract class BattleUnit : GameObject, IBattleUnit
    {
        public event UnitOnDeathHandler OnDeath;
    }
}
