using Microsoft.Xna.Framework.Graphics;

namespace AtlasMG.ECS.Components.Render
{
	public interface IRenderTexture2D : IRender2D
	{
		Texture2D Texture { get; set; }
	}
}
