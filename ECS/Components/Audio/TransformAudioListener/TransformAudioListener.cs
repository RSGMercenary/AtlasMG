using Atlas.ECS.Components;
using Microsoft.Xna.Framework.Audio;

namespace AtlasMG.ECS.Components.Audio
{
	public class TransformAudioListener : AtlasComponent, ITransformAudioListener
	{
		public AudioListener Listener { get; } = new AudioListener();

		public TransformAudioListener()
		{

		}
	}
}
