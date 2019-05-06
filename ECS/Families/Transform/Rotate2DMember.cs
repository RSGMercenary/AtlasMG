using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Transform;

namespace AtlasMG.ECS.Families.Render
{
	public class Rotate2DMember : AtlasFamilyMember
	{
		public ITransform2D Transform { get; }
		public IRotate2D Rotate { get; }
	}
}
