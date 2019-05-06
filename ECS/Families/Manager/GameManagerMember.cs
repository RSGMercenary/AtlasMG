using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Manager;

namespace AtlasMG.ECS.Families
{
	public class GameManagerMember : AtlasFamilyMember
	{
		public IGameManager GameManager { get; }
	}
}
