using Sandbox;

public sealed class BallController : Component
{
	[RequireComponent] Rigidbody rigidBody { get; set; }

	[Property] public int velocity { get; set; } = 1000;
	protected override void OnFixedUpdate()
	{

		if ( Input.Down( "forward" ) )
		{
			rigidBody.ApplyForce( Vector3.Forward * velocity );
		}
		if ( Input.Down( "backward" ) )
		{
			rigidBody.ApplyForce( Vector3.Backward * velocity );
		}
		if ( Input.Down( "left" ) )
		{
			rigidBody.ApplyForce( Vector3.Left * velocity );
		}
		if ( Input.Down( "right" ) )
		{
			rigidBody.ApplyForce( Vector3.Right * velocity );
		}
	}
}
