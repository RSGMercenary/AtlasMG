using Atlas.Core.Utilites;
using Atlas.ECS.Components.Component;
using Microsoft.Xna.Framework;

namespace AtlasMG.ECS.Components.Transform
{
	public class Transform2D : AtlasComponent<ITransform2D>, ITransform2D
	{
		#region Fields

		private Matrix local;

		private Vector2 position;
		private Vector2 scale;
		private float rotation;

		private bool dirty = false;

		#endregion

		#region Constructors

		public Transform2D() : this(new Vector2(0, 0)) { }
		public Transform2D(Vector2 position) : this(position, 0) { }
		public Transform2D(Vector2 position, float rotation) : this(position, rotation, new Vector2(1, 1)) { }

		public Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
			Set(position, rotation, scale);
		}

		#endregion

		protected void Dirty()
		{
			dirty = true;
		}

		public ITransform2D Parent
		{
			get { return Manager?.GetAncestorComponent<ITransform2D>(); }
		}

		public Matrix Global
		{
			get
			{
				var parent = Parent;
				var global = Local;
				if(parent != null)
					global *= parent.Global;
				return global;
			}
		}

		public Matrix Local
		{
			get
			{
				if(dirty)
				{
					local = CreateLocalMatrix();
					dirty = false;
				}
				return local;
			}
		}

		#region Position

		public Vector2 Position
		{
			get { return position; }
			set
			{
				if(position == value)
					return;
				position = value;
				Dirty();
			}
		}

		public float PositionX
		{
			get { return position.X; }
			set { Position = new Vector2(value, position.Y); }
		}

		public float PositionY
		{
			get { return position.Y; }
			set { Position = new Vector2(position.X, value); }
		}

		#endregion

		#region Scale

		public Vector2 Scale
		{
			get { return scale; }
			set
			{
				if(scale == value)
					return;
				scale = value;
				Dirty();
			}
		}

		public float ScaleX
		{
			get { return scale.X; }
			set { Scale = new Vector2(value, scale.Y); }
		}

		public float ScaleY
		{
			get { return scale.Y; }
			set { Scale = new Vector2(scale.X, value); }
		}

		public float ScaleXY
		{
			//TO-DO this is messed up!
			get { return scale.X; }
			set { Scale = new Vector2(value, value); }
		}

		#endregion

		#region Rotation

		public float Rotation
		{
			get { return rotation; }
			set
			{
				value = (float)Clamp.Radians(value);
				if(rotation == value)
					return;
				rotation = value;
				Dirty();
			}
		}

		#endregion

		public void Set(Vector2 position, float rotation, Vector2 scale)
		{
			Position = position;
			Rotation = rotation;
			Scale = scale;
		}

		protected virtual Matrix CreateLocalMatrix()
		{
			return Matrix.CreateScale(new Vector3(scale, 1)) *
				   Matrix.CreateRotationZ(rotation) *
				   Matrix.CreateTranslation(new Vector3(position, 0));
		}
	}
}
