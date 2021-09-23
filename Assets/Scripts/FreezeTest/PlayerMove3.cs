using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class PlayerMove3 : PlayerMoveBase
{
    // Works smoothly.
    protected override void teleport(Vector2 pos)
    {
        gameObject.SetActive(false);
        _rigidbody.position = pos;
        transform.position = pos;
        gameObject.SetActive(true);
    }
}