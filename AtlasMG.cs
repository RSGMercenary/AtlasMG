using Atlas.ECS.Components;
using AtlasMG.ECS;
using AtlasMG.ECS.Components.Render;
using AtlasMG.ECS.Components.Transform;
using AtlasMG.ECS.Systems;
using AtlasMG.ECS.Systems.Transform;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AtlasMG
{
	public class AtlasMG : Game
	{
		private AtlasEngine engine;

		public AtlasMG()
		{
			new GraphicsDeviceManager(this);
		}

		protected override void Initialize()
		{
			engine = AtlasGame.Create(this);

			SetupTestEntities();

			base.Initialize();
		}

		protected override void Update(GameTime gameTime)
		{
			if(GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			ITransform2D cam = engine.GetEntity("Camera").GetComponent<ITransform2D>();
			if(Keyboard.GetState().IsKeyDown(Keys.Q))
				cam.ScaleXY -= (float)(1d * gameTime.ElapsedGameTime.TotalSeconds);
			if(Keyboard.GetState().IsKeyDown(Keys.W))
				cam.ScaleXY += (float)(1d * gameTime.ElapsedGameTime.TotalSeconds);

			engine.Update(gameTime.ElapsedGameTime.TotalSeconds);

			base.Update(gameTime);
		}

		private void SetupTestEntities()
		{
			var root = engine.Manager;

			var systemManager = root.GetComponent<ISystemManager>();
			systemManager.AddSystem<TestSystem>();
			systemManager.AddSystem<Rotate2DSystem>();

			var camera = engine.GetEntity("Camera");

			var entity1 = camera.AddChild("1");

			entity1.AddComponent<ITransform2D>(new Transform2D(new Vector2(0, 0), 0, new Vector2(1, 1)));
			entity1.AddComponent<IRender2D>(new RenderTexture2D(new Texture2D(GraphicsDevice, 100, 100), new Vector2(50, 50), Color.Yellow));

			var entity2 = camera.AddChild("2");

			var rend = new RenderTexture2D(new Texture2D(GraphicsDevice, 100, 100), new Vector2(50, 50), Color.Red);
			rend.Color = new Color(255, 255, 255, 128);
			entity2.AddComponent<ITransform2D>(new Transform2D(new Vector2(50, 50), 0, new Vector2(1, 1)));
			entity2.AddComponent<IRender2D>(rend);
			entity2.AddComponent<IRotate2D>(new Rotate2D(0.05f));

			var entity21 = entity2.AddChild("2-1");

			rend = new RenderTexture2D(new Texture2D(GraphicsDevice, 100, 100), new Vector2(50, 50), Color.Blue);
			rend.Color = new Color(255, 255, 255, 32);
			entity21.AddComponent<ITransform2D>(new Transform2D(new Vector2(50, 50), 0, new Vector2(1, 1)));
			entity21.AddComponent<IRender2D>(rend);
			entity21.AddComponent<IRotate2D>(new Rotate2D(0.1f));

			var entity22 = entity2.AddChild("2-2");

			rend = new RenderTexture2D(new Texture2D(GraphicsDevice, 100, 100), new Vector2(50, 50), Color.Blue);
			rend.Color = new Color(255, 255, 255, 255);
			entity22.AddComponent<ITransform2D>(new Transform2D(new Vector2(100, 50), 0, new Vector2(1, 1)));
			entity22.AddComponent<IRender2D>(rend);
			entity22.AddComponent<IRotate2D>(new Rotate2D(0.1f));

			//world.GetComponent<ITransform2D>().ScaleXY = 1.3f;
			camera.GetComponent<ICamera2D>().Follow = entity2.GetComponent<ITransform2D>();

			var transform = engine.GetEntity("Cursor").GetComponent<ITransform2D, ICursorTransform2D>();
			//transform.IsDisabled = true;
			transform.Position = new Vector2(200, -100);
		}
	}
}
