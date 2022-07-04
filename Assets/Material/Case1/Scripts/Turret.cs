using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class Turret : MonoBehaviour, IDamagable // В наследниках не надо наследоваться от интерфейса
{
    protected List<Enemy> _enemies;
    protected Enemy _nearestTarget = null;

    private float _elapsedTime = 0;
    private float _timerDelay = 2f;

    protected void Start()
    {
        _enemies = FindObjectsOfType<Enemy>().ToList();
    }

    protected void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timerDelay)
        {
            _elapsedTime = 0;

            TryShoot();
        }
    }

    protected void TryShoot()
    {
        if (_enemies.Count > 0 && FindNearestEnemy()!= null)
        {
                _nearestTarget.TakeDamage();

                if (_nearestTarget.IsAlive == false)
                    _enemies.Remove(_nearestTarget);
        }
    }

    public abstract Enemy FindNearestEnemy(); // обязательно ли делать public? Как защитить?
}
