using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Physics;

namespace AtlasMG.ECS.Families.Physics
{
	public class AccelerationToVelocity2DMember : AtlasFamilyMember
	{
		public IAcceleration2D Acceleration { get; }
		public IVelocity2D Velocity { get; }
	}
}
