namespace TowerDeffence.Interfaces
{
    using System.Collections.Generic;

    public interface IRenderer
    {
        void Draw(ICollection<IDrawable> drawables);
    }
}
