using Sandbox;

public sealed class GameState : Component
{
	private static int Score { get; set; }

	public static void AddScore( int amount )
	{
		Score += amount;
	}

	protected override void OnAwake()
	{
		Score = 0;
		base.OnAwake();
	}
	protected override void OnUpdate()
	{
		Gizmo.Draw.ScreenText( $"Pontuação: {Score}", new Vector2( 10, 10 ) );

	}
}
