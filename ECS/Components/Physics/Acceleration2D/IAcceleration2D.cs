using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework;

namespace AtlasMG.ECS.Components.Physics
{
	public interface IAcceleration2D : IComponent
	{
		Vector2 Vector { get; set; }
		float Rotation { get; set; }
	}
}
