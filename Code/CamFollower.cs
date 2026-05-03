using Sandbox;

public sealed class CamFollower : Component
{
	[Property] GameObject Target { get; set; }
	[Property] Vector3 Offset { get; set; } = new Vector3( -300, 0, -50 );
	protected override void OnUpdate()
	{
		WorldPosition = Target.WorldPosition + Offset;
	}
}
