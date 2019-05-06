using Atlas.ECS.Families;
using AtlasMG.ECS.Components.Audio;

namespace AtlasMG.ECS.Families.Audio
{
	public class TransformAudioEmitterMember : AtlasFamilyMember
	{
		public ITransformAudioEmitter Emitter { get; }
		public IAudio Audio { get; }
	}
}
