using Godot;
using System;
using System.Collections.Generic;
using static Godot.TextServer;

public partial class Player : CharacterBody2D
{
    private AnimationPlayer _animationPlayer;

    private RayCast2D _rayCast2D;

    private TileMap _tileMap;

    private Vector2 _targetPosition;

    private Vector2 _targetDirection = new();

    private Vector2 _direction;

    private bool _isMoving = false;

    [Export]
    public TileMap TileMap
    {
        get => _tileMap;
        set
        {
            _tileMap = value;
            _tileSize = _tileMap.RenderingQuadrantSize;
        }
    }

    private readonly Dictionary<string, Vector2> inputs = new()
    {
        { "ui_left", Vector2.Left },
        { "ui_right", Vector2.Right },
        { "ui_up", Vector2.Up },
        { "ui_down", Vector2.Down }
    };


    private int _tileSize;

    public override void _Ready()
    {
        Position = Position.Snapped(Vector2.One * _tileSize);
        Position += Vector2.One * _tileSize / 2;

        _animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
        _rayCast2D = GetNode<RayCast2D>("RayCast2D");
    }
    
	private void HandleInput()
	{
        _direction = new();

        if (_isMoving)
        {
            return;
        }

        foreach(var input in inputs)
        {
            if (Input.IsActionPressed(input.Key))
            {
                _direction = input.Value;
            }
        }
    }

    private void Move(double delta)
    {
        if (!_isMoving && _direction != new Vector2())
        {
            _targetDirection = _direction.Normalized();
            _targetPosition = Position + (_targetDirection * _tileSize);
            _isMoving = true;
            
        }
        else if (_isMoving)
        {
            Velocity = Speed * _targetDirection;
            var distanceToTarget = Position.DistanceTo(_targetPosition);
            if (distanceToTarget < Velocity.Length())
            {
                Velocity = _targetDirection * distanceToTarget;
                _isMoving = false;
            }
            MoveAndSlide();
        }
    }

	private void UpdateAnimation()
	{
        if (!_isMoving)
        {
            _animationPlayer.Stop();
        }
        else
        {
            if (Velocity.X > 0)
            {
                _animationPlayer.Play("walk_right");
            }
            else if (Velocity.X < 0)
            {
                _animationPlayer.Play("walk_left");
            }
            else if (Velocity.Y < 0)
            {
                _animationPlayer.Play("walk_up");
            }
            else if (Velocity.Y > 0)
            {
                _animationPlayer.Play("walk_down");
            }
        }
    }

	public const float Speed = 16.0f;
	public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		HandleInput();
        Move(delta);
        UpdateAnimation();
    }
}
