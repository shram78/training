using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBase : Turret
{
    [SerializeField] private Base _base; 

   protected override Enemy FindEnemy()
    {
        float distanceToNearest = Mathf.Infinity;
        Enemy result = null;

        foreach (Enemy enemy in Enemies)
        {
            float currentDistance = (enemy.transform.position - _base.transform.position).magnitude;

            if (currentDistance < distanceToNearest)
            {
                result = enemy;
                distanceToNearest = currentDistance;
            }
        }
        return result;
    }
}
