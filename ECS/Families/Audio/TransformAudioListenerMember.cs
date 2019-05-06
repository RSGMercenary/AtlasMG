using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Audio;

namespace AtlasMG.ECS.Families.Audio
{
	public class TransformAudioListenerMember : AtlasFamilyMember
	{
		public ITransformAudioListener Listener { get; }
		public IAudio Audio { get; }
	}
}
