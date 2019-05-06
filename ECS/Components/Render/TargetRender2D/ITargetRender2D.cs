using Microsoft.Xna.Framework.Graphics;

namespace AtlasMG.ECS.Components.Render
{
	public interface ITargetRender2D : IRender2D
	{
		RenderTarget2D Target { get; }
	}
}
