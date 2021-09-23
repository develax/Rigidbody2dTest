using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class PlayerMove2 : PlayerMoveBase
{
    // Doesn't work smoothly.
    protected override void teleport(Vector2 pos)
    {
        _rigidbody.interpolation = RigidbodyInterpolation2D.None;
        _rigidbody.position = pos;
        _rigidbody.interpolation = RigidbodyInterpolation2D.Interpolate;
    }
}