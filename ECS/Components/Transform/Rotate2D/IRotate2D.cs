using Atlas.ECS.Components.Component;

namespace AtlasMG.ECS.Components.Transform
{
	public interface IRotate2D : IComponent
	{
		float Torque { get; set; }
	}
}
