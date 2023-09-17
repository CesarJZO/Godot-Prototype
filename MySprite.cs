using Godot;

namespace Prototype;

public sealed partial class MySprite : Sprite2D
{
    [Export] private int speed = 400;
    private float _angularSpeed = Mathf.Pi;

    public override void _Ready()
    {
        Timer timer = GetNode<Timer>("Timer");
        timer.Timeout += OnTimerTimeout;
    }

    public override void _Process(double delta)
    {
        Rotation += _angularSpeed * (float)delta;
        var velocity = Vector2.Up.Rotated(Rotation) * speed;
        Position += velocity * (float)delta;
    }

    public void OnButtonPressed()
    {
        SetProcess(!IsProcessing());
    }

    private void OnTimerTimeout()
    {
        Visible = !Visible;
    }
}
