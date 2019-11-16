using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework;

namespace AtlasMG.ECS.Components.Physics
{
	public class Acceleration2D : AtlasComponent<IAcceleration2D>, IAcceleration2D
	{
		private Vector2 vector = new Vector2(0, 0);
		private float rotation = 0;

		public Vector2 Vector
		{
			get { return vector; }
			set
			{
				if(vector == value)
					return;
				vector = value;
			}
		}

		public float Rotation
		{
			get { return rotation; }
			set
			{
				if(rotation == value)
					return;
				rotation = value;
			}
		}
	}
}
