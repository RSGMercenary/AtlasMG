using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework.Audio;

namespace AtlasMG.ECS.Components.Audio
{
	public interface ITransformAudioEmitter : IComponent
	{
		AudioEmitter Emitter { get; }
	}
}
