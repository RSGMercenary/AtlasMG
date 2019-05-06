using Microsoft.Xna.Framework.Graphics;

namespace AtlasMG.ECS.Components.Render
{
	public interface IRenderText2D : IRender2D
	{
		SpriteFont Font { get; set; }
		string Text { get; set; }
	}
}
