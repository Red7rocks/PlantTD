 using Godot;
using System;

public partial class RootMap : Node2D
{
	PackedScene saloonScene = GD.Load<PackedScene>("res://Scenes/rootSegment.tscn");
	Node2D rootSegments;
	public override void _Ready()
	{
		Roots = GetNode<Node2D>("Roots");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
