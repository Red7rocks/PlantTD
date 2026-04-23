using Godot;
using System;

public partial class RootSegment : Node2D
{
	PackedScene saloonScene = GD.Load<PackedScene>("res://Scenes/rootSegment.tscn");
	Node2D rootSegments;
	
	public override void _Ready()
	{
		Roots = GetNode<Node2D>("Roots");
	}
	private void addRoot(){
		
	}

	public override void _Process(double delta)
	{
		
	}
}
