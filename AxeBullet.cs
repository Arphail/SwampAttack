using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeBullet : Bullet
{
    private int _hitCount;

    private void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(Damage);
            _hitCount++;
        }

        if (_hitCount >= 3)
            Destroy(gameObject);
    }
}
