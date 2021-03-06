﻿using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework.Audio;

namespace AtlasMG.ECS.Components.Audio
{
	public class TransformAudioEmitter : AtlasComponent<ITransformAudioEmitter>, ITransformAudioEmitter
	{
		public AudioEmitter Emitter { get; } = new AudioEmitter();
	}
}
