using UnityEngine;

public class PlayerMovement : Movement
{
    protected override void MoveTo(Vector3 direction)
    {
        Rigidbody.AddForce(direction, ForceMode.Impulse);
    }
}