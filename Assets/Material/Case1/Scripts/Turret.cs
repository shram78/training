using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class Turret : MonoBehaviour
{
    private static List<Enemy> _enemies;

    [SerializeField] private float _elapsedTime;
    private bool _isInit = false;

    protected IEnumerable<Enemy> Enemies => _enemies;

    protected void Start()
    {
        if (_isInit == false)
        {
            _enemies = FindObjectsOfType<Enemy>().ToList();
        }

        InvokeRepeating(nameof(TryShoot), _elapsedTime, _elapsedTime);
        _isInit = true;
    }


    protected void TryShoot()
    {
        Enemy enemy = FindEnemy();

        if (_enemies.Count > 0)
        {
            enemy.TakeDamage();

            if (enemy.IsAlive == false)
                _enemies.Remove(enemy);
        }
    }

    protected abstract Enemy FindEnemy(); 
}
