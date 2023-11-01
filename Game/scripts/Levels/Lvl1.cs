using Godot;
using System;

public class Lvl1 : Node
{
	// Declare member variables here


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		NewGame();		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	public void ResetLevel()
	{
		GD.Print("reset level");
		var player = GetNode<Player>("Player");
		player.Hide();
		NewGame();
	}

	public void NewGame()
	{
		GD.Print("start level 1");
		var player = GetNode<Player>("Player");
		var startPosition = GetNode<Position2D>("StartPosition");
		player.Start(startPosition.Position);
	}
	
	private void FinishLevel()
	{
		GD.Print("start next level");
		GetTree().ChangeScene("res://scenes/Levels/Lvl2.tscn");
	}

}
