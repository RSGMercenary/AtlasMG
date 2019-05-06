using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Transform;

namespace AtlasMG.ECS.Families.Transform
{
	public class Camera2DMember : AtlasFamilyMember
	{
		public ITransform2D Transform { get; }
		public ICamera2D Camera { get; }
	}
}
