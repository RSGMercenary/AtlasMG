﻿using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework;

namespace AtlasMG.ECS.Components.Transform
{
	public interface ITransform2D : IComponent
	{
		//ITransform2D Parent { get; }
		Matrix Global { get; }
		Matrix Local { get; }

		Vector2 Position { get; set; }
		Vector2 Scale { get; set; }
		float Rotation { get; set; }

		void Set(Vector2 position, float rotation, Vector2 scale);

		float PositionX { get; set; }
		float PositionY { get; set; }
		float ScaleX { get; set; }
		float ScaleY { get; set; }
		float ScaleXY { get; set; }
	}
}
