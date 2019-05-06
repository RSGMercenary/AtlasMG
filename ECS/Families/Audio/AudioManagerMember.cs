using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Audio;

namespace AtlasMG.ECS.Families.Audio
{
	public class AudioManagerMember : AtlasFamilyMember
	{
		public IAudioManager AudioManager { get; }
	}
}
