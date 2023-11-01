using Godot;
using System;

public class StartGame : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private int count = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		if (Input.IsActionPressed("mouse_left_click")){
			GD.Print("Start Game!");
			GD.Print(count);
			count++;
			GetTree().ChangeScene("res://scenes/Levels/Lvl1.tscn");
		}
	}
}
