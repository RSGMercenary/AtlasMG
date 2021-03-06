﻿using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework;

namespace AtlasMG.ECS.Components.Render
{
	public interface IRender2D : IComponent
	{
		bool IsVisible { get; set; }
		Color GlobalColor { get; }
		Color Color { get; set; }
		Rectangle? Crop { get; set; }
		Vector2 Center { get; set; }
	}
}
