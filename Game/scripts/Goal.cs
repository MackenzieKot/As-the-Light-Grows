using Godot;
using System;

public class Goal : Area2D
{
	[Signal]
	public delegate void GoalHit();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var animatedSprite = GetNode<AnimatedSprite>("AnimatedSprite");
		animatedSprite.Playing = true;
	}

	private void OnGoalBodyEntered(object body)
	{
		EmitSignal(nameof(GoalHit));
	}
}
