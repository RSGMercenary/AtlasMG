using Atlas.ECS.Components;
using System.Collections.Generic;

namespace AtlasMG.ECS.Components.Audio
{
	public interface IAudio : IComponent, IEnumerable<Sound>
	{
		/*
		IReadOnlyList<Sound> Sounds { get; }
		*/
	}
}
