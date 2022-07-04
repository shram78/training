using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool IsAlive { get; private set; }

    public void TakeDamage()
    {
        Debug.Log(gameObject.name + " take damage");
        IsAlive = false;

        Destroy(gameObject);
    }
}
