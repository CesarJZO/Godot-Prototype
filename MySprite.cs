using Godot;

namespace Prototype;

public sealed partial class MySprite : Sprite2D
{
    private int _speed = 400;
    private float _angularSpeed = Mathf.Pi;

    public override void _Process(double delta)
    {
        Rotation += _angularSpeed * (float)delta;

        Vector2 velocity = Vector2.Up.Rotated(Rotation) * _speed;

        Position += velocity * (float)delta;
    }
}
