using Godot;
using System;

public class House2Lit : Area2D
{
	[Signal]
	public delegate void Hit();
	
	private void OnEnemyBodyEntered(object body)
	{
		EmitSignal(nameof(Hit));
	}
}
