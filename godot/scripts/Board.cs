using Godot;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

public partial class Board : Node
{
	[Export]
	public PackedScene TileScene = GD.Load<PackedScene>("res://scenes/Tile.tscn");
	private bool initialized = false;
	private int size = 7;

	public void GenerateBoard()
	{
		GD.Print("Generating Board");
		Node tilesNode = new Node();
		this.AddChild(tilesNode, true, InternalMode.Disabled);

		GD.Print("Added Tiles Node");
		GD.Print("Generating Board with size: " + size);

		int halfSize = size / 2;
		for (int x = -halfSize; x <= halfSize; x++)
		{
			for (int z = -halfSize; z <= halfSize; z++)
			{
				Node3D tile = TileScene.Instantiate<Node3D>();
				tile.Position = new Vector3((x * 10), 1, (z * 10));
				tilesNode.AddChild(tile);
				GD.Print("Added Tile at position: " + tile.Position);
			}
		}
		initialized = true;
	}

	public void GenerateBoard(int size)
	{
		this.size = size;
		GenerateBoard();
	}


}
