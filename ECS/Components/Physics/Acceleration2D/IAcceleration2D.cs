using Microsoft.Xna.Framework;

namespace AtlasMG.ECS.Components.Physics
{
	public interface IAcceleration2D
	{
		Vector2 Vector { get; set; }
		float Rotation { get; set; }
	}
}
