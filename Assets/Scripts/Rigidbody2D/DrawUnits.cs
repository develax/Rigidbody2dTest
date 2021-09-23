using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class DrawUnits : MonoBehaviour
{
#pragma warning disable CS0649

    //[SerializeField]
    //private GameObject _test;

#pragma warning restore CS0649

    private void OnDrawGizmos()
    {
        for (int i = -9; i < 10; i++)
        {
            Gizmos.DrawCube(Vector2.right * i, Vector2.one * 0.1f);
        }
    }
}