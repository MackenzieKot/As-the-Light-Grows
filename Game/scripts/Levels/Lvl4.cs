using Godot;
using System;

public class Lvl4 : Node
{	
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
		var car1 = GetNode<CarRed>("CarRed");
		var carRedStartPosition = GetNode<Position2D>("CarRedStartPosition");
		car1.Start(carRedStartPosition.Position);
		
		var car2 = GetNode<CarGreen>("CarGreen");
		var carGreenStartPosition = GetNode<Position2D>("CarGreenStartPosition");
		car2.Start(carGreenStartPosition.Position);		
		
		var car3 = GetNode<CarRed>("CarRed2");
		var carRedStartPosition2 = GetNode<Position2D>("CarRedStartPosition2");
		car3.Start(carRedStartPosition2.Position);
		
		var car4 = GetNode<CarGreen>("CarGreen2");
		var carGreenStartPosition2 = GetNode<Position2D>("CarGreenStartPosition2");
		car4.Start(carGreenStartPosition2.Position);
		
		var player = GetNode<Player>("Player");
		var startPosition = GetNode<Position2D>("StartPosition");
		player.Start(startPosition.Position);
	}
	
	private void FinishLevel()
	{
		GetTree().ChangeScene("res://scenes/End Cards/Lvl4EndCard1.tscn");
	}

}


