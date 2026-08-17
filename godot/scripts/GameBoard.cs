using Godot;
using System;

public partial class GameBoard : Node
{
	private Board board;
	public override void _Ready()
	{
		GD.Print("GameBoard _Ready");
		board = GetNode<Board>("Board");
		generate_board();
	}

	private void generate_board()
	{
		board.GenerateBoard();
	}
}
