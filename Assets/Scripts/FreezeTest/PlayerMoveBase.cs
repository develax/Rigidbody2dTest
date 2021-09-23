using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMoveBase : MonoBehaviour
{
#pragma warning disable CS0649

    [SerializeField]
    private KeyCode _moveKey;

    [SerializeField]
    protected Rigidbody2D _rigidbody;

    [SerializeField]
    private Transform _ground;

    [SerializeField]
    private Vector2 _velocity = Vector2.right / 2;

#pragma warning restore CS0649

    private void Awake()
    {
        calcGroundSize();
        calcTeleportPosition();
    }

    private void Update()
    {
        if (Input.GetKey(_moveKey))
            _move = true;
    }

    private void FixedUpdate()
    {
        if (!_move)
            return;

        _move = false;
        checkTeleportTrigger();
        moveForward();
    }

    #region Helpers

    private Vector2 _groundSize;
    private bool _move;
    private float _teleportTriggerX;

    private void calcGroundSize()
    {
        SpriteRenderer spriteRenderer = _ground.GetComponent<SpriteRenderer>();
        _groundSize = spriteRenderer.sprite.bounds.size * _ground.localScale.x;
    }

    private void calcTeleportPosition()
    {
        // when the Player reaches the end of the 2nd Ground platform it is teleported at the end of the 1st Ground platform
        _teleportTriggerX = _ground.position.x + _groundSize.x * 1.5f;
    }

    private void checkTeleportTrigger()
    {
        if (_rigidbody.position.x < _teleportTriggerX)
            return;

        Debug.Log($"Teleport: {this.GetType().Name}");
        teleport(new Vector2(_rigidbody.position.x - _groundSize.x, _rigidbody.position.y)); 
    }

    private void moveForward()
    {
        _rigidbody.MovePosition(_rigidbody.position + _velocity);
    }

    protected abstract void teleport(Vector2 pos);

    #endregion
}