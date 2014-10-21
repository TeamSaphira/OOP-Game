namespace TowerDeffence.Graphics
{
    using Interfaces;

    public abstract class Renderer : IRenderer
    {
        public void Draw(System.Collections.Generic.ICollection<IDrawable> drawables)
        {
            throw new System.NotImplementedException();
        }
    }
}
