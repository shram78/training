using UnityEngine;

public class TurretRadial : Turret
{
    [SerializeField] private float _searchRadius = 0;

    public override Enemy FindNearestEnemy()
    {
        float distanceToNearest = Mathf.Infinity;

        foreach (Enemy enemy in _enemies)
        {
            float currentDistance = (enemy.transform.position - transform.position).magnitude;

            if (currentDistance < distanceToNearest)
            {
                _nearestTarget = enemy;
                distanceToNearest = currentDistance;
            }
        }

        if (distanceToNearest > _searchRadius)
            return null;
        else
            return _nearestTarget;
    }
}
