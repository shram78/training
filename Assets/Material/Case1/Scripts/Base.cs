using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Base : MonoBehaviour
{
    private List<Enemy> _enemies;
    private Enemy _nearestTarget = null;

    protected void Start()
    {
        _enemies = FindObjectsOfType<Enemy>().ToList();
    }
    public Enemy FindNearestEnemy()
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
        _enemies.Remove(_nearestTarget);

        return _nearestTarget;
    }
}
