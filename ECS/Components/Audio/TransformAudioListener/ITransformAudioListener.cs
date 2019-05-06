using Atlas.ECS.Components;
using Microsoft.Xna.Framework.Audio;

namespace AtlasMG.ECS.Components.Audio
{
	public interface ITransformAudioListener : IComponent
	{
		AudioListener Listener { get; }
	}
}
