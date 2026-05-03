using System;
using Sandbox;

public sealed class Gem : Component
{
	protected override void OnUpdate()
	{
		LocalPosition = LocalPosition + MathF.Sin( Time.Now * 2.5f ) * Vector3.Up;
		LocalRotation *= Rotation.FromYaw( 90f * Time.Delta );
	}
}
