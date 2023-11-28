using Godot;
using System;

public class Lvl4EndCard2 : Node2D
{
	bool clickReady = false;
	
	public override void _Process(float delta)
	{
		if (clickReady && Input.IsActionPressed("mouse_left_click")){
			GetTree().ChangeScene("res://scenes/Levels/StartGame.tscn");
		}
	}	

	private void OnTimerTimeout()
	{
		clickReady = true;
	}
}
