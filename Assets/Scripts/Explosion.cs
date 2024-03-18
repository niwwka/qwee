using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float damage = 50;
    public float maxSize = 15;
    public float speed = 10;

    private void Start()
    {
        transform.localScale = Vector3.zero;
    }
    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * speed;

        if (transform.localScale.x > maxSize)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHealth = other.GetComponent<PlayerHealth>();
        if (PlayerHealth != null)
        {
            PlayerHealth.DealDamage(damage);
        }
        var enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }
}
