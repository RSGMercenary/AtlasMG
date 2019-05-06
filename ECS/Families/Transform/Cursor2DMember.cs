using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Transform;

namespace AtlasMG.ECS.Families.Transform
{
	public class Cursor2DMember : AtlasFamilyMember
	{
		public ITransform2D Transform { get; }
		public ICursor2D Cursor { get; }
	}
}
