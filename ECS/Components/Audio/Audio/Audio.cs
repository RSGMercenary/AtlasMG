using Atlas.ECS.Components;
using System.Collections;
using System.Collections.Generic;

namespace AtlasMG.ECS.Components.Audio
{
	public class Audio : AtlasComponent, IAudio
	{
		public Audio()
		{
			/*
			var listener = new AudioListener();
			listener;
			var emitter = new AudioEmitter();
			emitter.
			*/
		}

		public IEnumerator<Sound> GetEnumerator()
		{
			throw new System.NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
	}
}
