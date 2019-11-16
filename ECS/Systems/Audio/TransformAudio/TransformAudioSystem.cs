using Atlas.ECS.Components.Engine;
using Atlas.ECS.Families;
using Atlas.ECS.Systems;
using AtlasMG.ECS.Families.Audio;

namespace AtlasMG.ECS.Systems.Audio
{
	public class TransformAudioSystem : AtlasSystem, ITransformAudioSystem
	{
		private IFamily<TransformAudioListenerMember> listeners;
		private IFamily<TransformAudioEmitterMember> emitters;

		public TransformAudioSystem()
		{

		}

		protected override void AddingEngine(IEngine engine)
		{
			base.AddingEngine(engine);
			listeners = engine.AddFamily<TransformAudioListenerMember>();
			emitters = engine.AddFamily<TransformAudioEmitterMember>();
		}

		protected override void RemovingEngine(IEngine engine)
		{
			engine.RemoveFamily<TransformAudioListenerMember>();
			engine.RemoveFamily<TransformAudioEmitterMember>();
			listeners = null;
			emitters = null;
			base.RemovingEngine(engine);
		}

		protected override void SystemUpdate(float deltaTime)
		{
			/*
			foreach(var listener in listeners)
			{
				listener.Listener.Listener.Position = listener.Entity.GlobalMatrix.Translation;

				foreach(var emitter in emitters)
				{
					emitter.Emitter.Emitter.Position = emitter.Entity.GlobalMatrix.Translation;

					foreach(var sound in emitter.Audio)
					{
						//Apply listener and emitter to all sounds that are 3D.

					}
				}
			}
			*/
		}
	}
}
