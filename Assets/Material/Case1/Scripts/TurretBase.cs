using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBase : Turret
{
    [SerializeField] private Base _base;
    public override Enemy FindNearestEnemy()
    {
        _nearestTarget = _base.FindNearestEnemy();

        return _nearestTarget;
    }
}
