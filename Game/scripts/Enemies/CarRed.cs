using Godot;
using System;

public class CarRed : Area2D
{
	[Signal]
	public delegate void Hit();
	
	[Export]
	public int Speed = 200;
	[Export]
	public int endPoint = -2000;
	public Vector2 ScreenSize; //game window size

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;
		
	}

	//Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		var velocity = Vector2.Zero; //movement vector
		velocity.x -= 1;
		velocity = velocity.Normalized() * Speed;
		Position += velocity * delta;
		Position = new Vector2(x: Mathf.Clamp(Position.x, endPoint, ScreenSize.x*6), y: Mathf.Clamp(Position.y, 0, ScreenSize.y));
	}
	
	public void Start(Vector2 pos){
		Position = pos;
		Show();
	}
	
	private void OnEnemyBodyEntered(object body)
	{
		GD.Print("red");
		EmitSignal(nameof(Hit));
	}
}
