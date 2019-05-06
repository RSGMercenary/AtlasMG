using Microsoft.Xna.Framework.Audio;
using System.Collections.Generic;

namespace AtlasMG.ECS.Components.Audio
{
	public class Sound
	{
		private static readonly Dictionary<string, SoundEffect> effects = new Dictionary<string, SoundEffect>();


		private float time = 0;
		private SoundEffect effect;
		private SoundEffectInstance instance;

		public string Name { get; set; }
		public string Url { get; set; }

		public bool Loop { get; set; }

		public Sound()
		{
			//instance.Apply3D()
		}

		public void Update(float deltaTime)
		{
			CurrentTime += deltaTime;
		}

		public float TotalTime
		{
			get { return (float)effect.Duration.TotalSeconds; }
		}

		public float CurrentTime
		{
			get { return time; }
			set
			{
				/*
				if(value < 0)
					value = 0;
				if(value > Duration)
					value = Duration;
				if(time == value)
					return;
				time = value;
				*/
			}
		}
	}
}
