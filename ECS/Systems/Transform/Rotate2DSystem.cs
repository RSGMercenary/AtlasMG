using Atlas.ECS.Systems;
using AtlasMG.ECS.Families.Render;

namespace AtlasMG.ECS.Systems.Transform
{
	public class Rotate2DSystem : AtlasFamilySystem<Rotate2DMember>
	{
		public Rotate2DSystem()
		{

		}

		protected override void MemberUpdate(float deltaTime, Rotate2DMember member)
		{
			member.Transform.Rotation += member.Rotate.Torque * deltaTime;
		}
	}
}
