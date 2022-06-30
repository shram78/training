using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody))]

public abstract class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private IInput _input;

    protected Rigidbody Rigidbody { get; private set; }

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();

        _input = GetComponent<IInput>();

        if (_input == null)
            throw new ArgumentNullException("movement requere input");
    }

    private void FixedUpdate()
    {
        MoveTo(_input.Direction * _speed * Time.deltaTime);
    }

    protected abstract void MoveTo(Vector3 direction);
}
