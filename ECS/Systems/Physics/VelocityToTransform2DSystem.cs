using Atlas.Core.Objects;
using Atlas.ECS.Systems;
using AtlasMG.ECS.Families.Physics;

namespace AtlasMG.ECS.Systems.Physics
{
	public class VelocityToTransform2DSystem : AtlasFamilySystem<VelocityToTransform2DMember>
	{
		public VelocityToTransform2DSystem()
		{
			TimeStep = TimeStep.Fixed;
		}

		protected override void MemberUpdate(float deltaTime, VelocityToTransform2DMember member)
		{
			member.Transform.Position += member.Velocity.Vector * deltaTime;
			member.Transform.Rotation += member.Velocity.Rotation * deltaTime;
		}
	}
}
