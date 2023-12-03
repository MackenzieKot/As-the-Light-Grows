using Godot;
using System;

public class StartGame : Node2D
{
	bool clickReady = false;
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		if (clickReady && Input.IsActionPressed("mouse_left_click")){
			GetTree().ChangeScene("res://scenes/Levels/Lvl1.tscn");
		}
	}
	
	private void OnTimerTimeout()
	{
		clickReady = true;
	}
}
