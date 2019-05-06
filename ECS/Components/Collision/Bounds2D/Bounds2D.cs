using Atlas.ECS.Components;
using AtlasMG.ECS.Components.Transform;
using Microsoft.Xna.Framework;

namespace AtlasMG.ECS.Components.Collision
{
	public class Bounds2D : AtlasComponent, IBounds2D
	{
		//This is calculated from the Bounds
		private ITransform2D transform;

		public Rectangle AABB { get; set; }


		public Rectangle Bounds { get; set; }

		public Bounds2D()
		{

		}
	}
}
