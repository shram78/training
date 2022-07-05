using UnityEngine;
using System.Linq;

public class TurretRadial : Turret
{
    [SerializeField] private float _searchRadius = 0;

    protected override Enemy FindEnemy()
    {
        Enemy result = null;

        Collider[] colliders = Physics.OverlapSphere(transform.position, _searchRadius);

        colliders.FirstOrDefault(collider => collider.TryGetComponent(out result));

        return result;
    }
}
