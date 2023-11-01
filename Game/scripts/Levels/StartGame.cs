using Godot;
using System;

public class StartGame : Node2D
{
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		if (Input.IsActionPressed("mouse_left_click")){
			GetTree().ChangeScene("res://scenes/Levels/Lvl1.tscn");
		}
	}
}
