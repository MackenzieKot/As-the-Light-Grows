using Godot;
using System;

public class Lvl1 : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		NewGame();
	}

	public void ResetLevel()
	{
		var player = GetNode<Player>("Player");
		player.Hide();
		NewGame();
	}

	public void NewGame()
	{
		var player = GetNode<Player>("Player");
		var startPosition = GetNode<Position2D>("StartPosition");
		player.Start(startPosition.Position);
	}
	
	private void FinishLevel()
	{
		GetTree().ChangeScene("res://scenes/Levels/Lvl2.tscn");
	}
}
