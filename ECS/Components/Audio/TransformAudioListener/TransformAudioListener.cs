using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework.Audio;

namespace AtlasMG.ECS.Components.Audio
{
	public class TransformAudioListener : AtlasComponent<ITransformAudioListener>, ITransformAudioListener
	{
		public AudioListener Listener { get; } = new AudioListener();

		public TransformAudioListener()
		{

		}
	}
}
