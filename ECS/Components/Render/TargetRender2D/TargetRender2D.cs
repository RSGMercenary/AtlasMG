using Microsoft.Xna.Framework.Graphics;

namespace AtlasMG.ECS.Components.Render
{
	public class TargetRender2D : Render2D, ITargetRender2D
	{
		public RenderTarget2D Target { get; }
	}
}
