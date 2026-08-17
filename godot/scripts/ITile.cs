using System;
using godot.scripts;

public abstract class ITile
{
    public string Name { get; }
    public string Description { get; }
    public double Value { get; set; }

    public IMoveBehavior MoveBehavior = new Static_MoveBehavior();
}
