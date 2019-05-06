namespace AtlasMG.ECS.Components.Transform
{
	public interface ICursorTransform2D : ITransform2D
	{
		bool FollowPosition { get; set; }
		bool FollowRotation { get; set; }
	}
}
