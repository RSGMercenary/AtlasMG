using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Physics;
using AtlasMG.ECS.Components.Transform;

namespace AtlasMG.ECS.Families.Physics
{
	public class VelocityToTransform2DMember : AtlasFamilyMember
	{
		public IVelocity2D Velocity { get; }
		public ITransform2D Transform { get; }
	}
}
