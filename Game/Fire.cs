using Godot;
using System;

public class Fire : StaticBody2D
{
	// Declare member variables here. Examples:

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var animatedSprite = GetNode<AnimatedSprite>("AnimatedSprite");
		animatedSprite.Playing = true;
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
