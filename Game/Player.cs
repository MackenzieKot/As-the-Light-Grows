using Godot;
using System;

public class Player : Area2D{
	[Signal]
	public delegate void Hit();
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export]
	public int Speed = 350; //pixels/sec
	public Vector2 ScreenSize; //game window size

	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
		ScreenSize = GetViewportRect().Size;
		//Hide();
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta){
	  	var velocity = Vector2.Zero; //movement vector
	
		if (Input.IsActionPressed("move_right")){
			velocity.x += 1;
		}

		if (Input.IsActionPressed("move_left")){
			velocity.x -= 1;
		}

		if (Input.IsActionPressed("move_down")){
			velocity.y += 1;
		}

		if (Input.IsActionPressed("move_up")){
			velocity.y -= 1;
		}
		
		var animatedSprite = GetNode<AnimatedSprite>("AnimatedSprite");

		if (velocity.Length() > 0){
			velocity = velocity.Normalized() * Speed;
			animatedSprite.Play();
		}
		else{
			animatedSprite.Stop();
		}
		
		Position += velocity * delta;
		Position = new Vector2(x: Mathf.Clamp(Position.x, 0, ScreenSize.x), y: Mathf.Clamp(Position.y, 0, ScreenSize.y));
	
		if (velocity.x != 0){
			animatedSprite.Animation = "walk";
			animatedSprite.FlipV = false;
			animatedSprite.FlipH = velocity.x < 0;
		}
		
	}
	
	public void OnPlayerBodyEntered(object body){
		Hide(); // Player disappears after being hit.
		EmitSignal(nameof(Hit));
		GetNode<CollisionShape2D>("CollisionShape2D").SetDeferred("disabled", true);
	}

	public void Start(Vector2 pos){
		Position = pos;
		Show();
		GetNode<CollisionShape2D>("CollisionShape2D").Disabled = false;
	}

}
