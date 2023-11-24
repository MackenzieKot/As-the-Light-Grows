using Godot;
using System;

public class Lvl4EndCard2 : Node2D
{
  public override void _Process(float delta)
  {
	  if (Input.IsActionPressed("mouse_left_click")){
			GetTree().ChangeScene("res://scenes/Levels/StartGame.tscn");
		}
  }
}
