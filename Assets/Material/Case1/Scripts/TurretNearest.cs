using UnityEngine;

public class TurretNearest : Turret
{
    protected override Enemy FindEnemy()
    {
        float distanceToNearest = Mathf.Infinity;
        Enemy result = null;

        foreach (Enemy enemy in Enemies)
        {
            float currentDistance = (enemy.transform.position - transform.position).magnitude;

            if (currentDistance < distanceToNearest)
            {
                result = enemy;
                distanceToNearest = currentDistance;
            }
        }
        return result;
    }
}