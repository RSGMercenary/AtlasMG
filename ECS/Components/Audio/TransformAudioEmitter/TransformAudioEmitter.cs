using Atlas.ECS.Components;
using Microsoft.Xna.Framework.Audio;

namespace AtlasMG.ECS.Components.Audio
{
	public class TransformAudioEmitter : AtlasComponent, ITransformAudioEmitter
	{
		public AudioEmitter Emitter { get; } = new AudioEmitter();
	}
}
