using Godot;
using System;

namespace godot.scripts
{
	public partial class EmptyTile : Node3D
	{
		private bool isRevealed = false;
		private Vector2 grid_coord = Vector2.Zero;

		public void move_to_grid(Vector2 vector2)
		{
			grid_coord = vector2;
		}
	}
}