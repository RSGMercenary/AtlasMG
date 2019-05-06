using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Audio;

namespace AtlasMG.ECS.Families.Audio
{
	public class AudioMember : AtlasFamilyMember
	{
		public IAudio Audio { get; }
	}
}
