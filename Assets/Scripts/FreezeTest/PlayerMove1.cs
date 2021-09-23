using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class PlayerMove1 : PlayerMoveBase
{
    // Causes kind of "freeze".
    protected override void teleport(Vector2 pos)
    {
        transform.position = pos;
    }
}