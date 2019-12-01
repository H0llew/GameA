using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace GameA.Engine
{
    /// <summary>
    /// Represents a 2d texture (sprite)
    /// </summary>
    public class Sprite
    {
        public Texture2D Texture { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Instantie a new Sprite with custom dimensions
        /// </summary>
        /// <param name="PATH">Path to a picture</param>
        /// <param name="width">width of sprite</param>
        /// <param name="height">height of sprite</param>
        public Sprite(string PATH, int width, int height)
        {
            Texture = Main.contentManager.Load<Texture2D>(PATH);

            this.Width = width;
            this.Height = height;
        }
        /// <summary>
        /// Instantie a new Sprite with picture dimensions
        /// </summary>
        /// <param name="PATH"></param>
        public Sprite(string PATH)
        {
            Texture = Main.contentManager.Load<Texture2D>(PATH);

            this.Width = Texture.Width;
            this.Height = Texture.Height;
        }
    }
}
