namespace TowerDeffence.Interfaces
{
    using System.Collections.Generic;

    public interface IRenderer
    {
        void Draw(IList<IDrawable> drawables);

        void DrawGameMenu();

        void DrawGameWindow();

        void DrawAuthors();

        void DrawGameInfo();

        void DrawMap(IMap map, int left, int top);

        void DrawEnemiesInfo(IList<object> units);
    }
}
