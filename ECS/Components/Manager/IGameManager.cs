using Atlas.ECS.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AtlasMG.ECS.Components.Manager
{
	public interface IGameManager : IComponent
	{
		Game Game { get; }
		Color BackgroundColor { get; set; }
		SpriteBatch SpriteBatch { get; }
		GraphicsDeviceManager GraphicsDeviceManager { get; }
	}
}
