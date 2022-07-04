using UnityEngine;

public class EnemyMovement : Movement
{
    protected override void MoveTo(Vector3 direction)
    {
         Rigidbody.AddForce(direction);
    }
}
