using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Esse arquivo contem as classes ImagemEstatica e ImagemEstaticaRedimensionavel
namespace BruteWarriors.Componentes 
{
    public class ImagemEstatica : IBackground
    {
        public ImagemEstatica(Texture2D tex, Rectangle size)
        {
            _textura = tex;
            this.viewSize = size;
        }

        Texture2D _textura;
        Rectangle viewSize;
        
        public int Height
        {
            get => this.viewSize.Height;
            set => this.viewSize.Height = value;
        }


        public int Width { get => viewSize.Width; set => viewSize.Width = value; }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_textura, viewSize, Color.White);
        }


    }

    public class ImagemEstaticaRedimensionavel : IBackground, IResizable
    {
        public ImagemEstaticaRedimensionavel(Texture2D tex, Rectangle size)
        {
            _textura = tex;
            this.viewSize = size;
        }

        Texture2D _textura;
        Rectangle viewSize;

        public int Height
        {
            get => this.viewSize.Height;
            set => this.viewSize.Height = value;
        }


        public int Width { get => viewSize.Width; set => viewSize.Width = value; }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_textura, viewSize, Color.White);
        }

        public void OnResize(int newHeight, int newWidth)
        {
            Height = newHeight;
            Width = newWidth;
        }
    }
}
