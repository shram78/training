using UnityEngine;

public class TurretNearest : Turret
{
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
        return _nearestTarget;
    }
}