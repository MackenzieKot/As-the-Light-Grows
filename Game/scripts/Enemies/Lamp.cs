using Godot;
using System;

public class Lamp : Area2D
{
	[Signal]
	public delegate void Hit();
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	
	private void OnEnemyBodyEntered(object body)
	{
		GD.Print("death collision");
		EmitSignal(nameof(Hit));
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
