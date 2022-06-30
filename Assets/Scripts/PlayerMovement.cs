using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
       MoveTranslate();
       //MoveRigidbody();
    }

    private void MoveTranslate()
    {
        float forwadrDirection = Input.GetAxis(Horizontal);
        float leftDirection = Input.GetAxis(Vertical);

        Vector3 moveDirection = new Vector3(forwadrDirection, 0.0f, leftDirection);

        transform.Translate(moveDirection * _speed * Time.deltaTime);
    }

    private void MoveRigidbody()
    {
        float forwadrDirection = Input.GetAxis(Horizontal);
        float leftDirection = Input.GetAxis(Vertical);

        Vector3 moveDirection = new Vector3(forwadrDirection, 0.0f, leftDirection);

        _rigidbody.AddForce(moveDirection * _speed * Time.deltaTime, ForceMode.Impulse);
    }

}
