using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour, IInput
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    public Vector3 Direction { get; private set; }

    private void Update()
    {
        float forwadrDirection = Input.GetAxis(Horizontal);
        float leftDirection = Input.GetAxis(Vertical);
        Direction = new Vector3(forwadrDirection, 0.0f, leftDirection);
    }
}
