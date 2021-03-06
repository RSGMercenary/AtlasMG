﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;

namespace AtlasMG.ECS.Components.Render
{
	public class RenderTexture2D : Render2D, IRenderTexture2D
	{
		public Texture2D Texture { get; set; }

		public RenderTexture2D()
		{

		}

		public RenderTexture2D(Texture2D texture)
		{
			Texture = texture;
		}

		public RenderTexture2D(Texture2D texture, Color fill)
		{
			Texture = texture;
			Fill(fill);
		}

		public RenderTexture2D(Texture2D texture, Vector2 origin, Color fill)
		{
			Texture = texture;
			Center = origin;
			Fill(fill);
		}

		public void Fill(Color color)
		{
			var range = Texture.Width * Texture.Height;
			Texture.SetData(Enumerable.Range(0, range).Select(p => color).ToArray());
		}
	}
}
