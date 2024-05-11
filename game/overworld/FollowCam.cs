using Godot;
using System;

public partial class FollowCam : Camera2D
{
	[Export]
	public TileMap Map { get; set; }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var mapRectangle = Map.GetUsedRect();
		var tileSize = Map.RenderingQuadrantSize;
		var worldSizeInPixels = mapRectangle.Size * tileSize;
		LimitRight = worldSizeInPixels.X;
        LimitBottom = worldSizeInPixels.Y;
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
