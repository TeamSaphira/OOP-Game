namespace TowerDeffence.Graphics
{
    using System.Collections.Generic;

    using Interfaces;

    public class ScreenRenderer : IRenderer
    {
        public ICollection<IDrawable> Drawables
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void Draw(ICollection<IDrawable> drawables)
        {
            
        }
    }
}
