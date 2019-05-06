using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Render;
using AtlasMG.ECS.Components.Transform;

namespace AtlasMG.ECS.Families.Render
{
	public class Render2DMember : AtlasFamilyMember
	{
		public ITransform2D Transform { get; }
		public IRender2D Render { get; }
	}
}
