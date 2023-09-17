using Godot;

namespace Prototype;

public sealed partial class MySprite : Sprite2D
{
    [Export] private int speed = 400;
    private float _angularSpeed = Mathf.Pi;

    public override void _Process(double delta)
    {
        float direction = 0f;

        if (Input.IsActionPressed("ui_right"))
            direction += 1f;
        else if (Input.IsActionPressed("ui_left"))
            direction -= 1f;

        Rotation += _angularSpeed * direction * (float)delta;

        Vector2 velocity = Vector2.Zero;
        if (Input.IsActionPressed("ui_up"))
            velocity = Vector2.Up.Rotated(Rotation) * speed;

        Position += velocity * (float)delta;
    }
}
