using Godot;
using System;

public class Player : KinematicBody2D{
	[Signal]
	public delegate void Hit();

	[Export]
	public int Speed = 200;
	public Vector2 ScreenSize; //game window size

	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
		ScreenSize = GetViewportRect().Size;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(float delta){		
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
		Position = new Vector2(x: Mathf.Clamp(Position.x, 0, ScreenSize.x*5), y: Mathf.Clamp(Position.y, 0, ScreenSize.y));

		if (velocity.x != 0){
			animatedSprite.Animation = "walk";
			animatedSprite.FlipV = false;
			animatedSprite.FlipH = velocity.x < 0;
		}
		
		MoveAndSlide(velocity);
	}

	public void Start(Vector2 pos){
		Position = pos;
		Show();
	}
}
