using Atlas.ECS.Components.Engine;
using Atlas.ECS.Families;
using Atlas.ECS.Systems;
using AtlasMG.ECS.Families.Audio;

namespace AtlasMG.ECS.Systems.Audio
{
	public class AudioSystem : AtlasSystem, IAudioSystem
	{
		private IFamily<AudioManagerMember> managers;
		private IFamily<AudioMember> audios;

		public AudioSystem()
		{

		}

		protected override void AddingEngine(IEngine engine)
		{
			base.AddingEngine(engine);
			managers = engine.AddFamily<AudioManagerMember>();
			audios = engine.AddFamily<AudioMember>();
		}

		protected override void RemovingEngine(IEngine engine)
		{
			engine.RemoveFamily<AudioManagerMember>();
			engine.RemoveFamily<AudioMember>();
			managers = null;
			audios = null;
			base.RemovingEngine(engine);
		}

		protected override void SystemUpdate(float deltaTime)
		{
			/*foreach(var manager in managers)
			{
				foreach(aud)
			}*/
		}

		/*
		protected override void MemberUpdate(float deltaTime, AudioMember member)
		{
			foreach(var sound in member.Audio)
			{
				if(sound.Instance.State == SoundState.Playing)
					sound.CurrentTime += deltaTime;
			}
		}
		*/
	}
}
