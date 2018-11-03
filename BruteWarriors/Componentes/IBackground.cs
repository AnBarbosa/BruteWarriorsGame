using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteWarriors.Componentes
{
    interface IBackground
    {
        int Height { get; }
        int Width { get; }
        void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }

    interface IResizable
    {
        void OnResize(int newHeight, int newWidth);
    }

}
