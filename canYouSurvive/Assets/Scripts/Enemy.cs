using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public int health = 100;
    public GameObject deathEffect;
    public float speed;
    public bool flip;
    // Start is called before the first frame update
    private void Update()
    {
        Vector3 scale = transform.localScale;
        if (Player.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1 * (flip ? -1 : 1);
            transform.Translate(speed * Time.deltaTime, 0, 0);
        } else
        {
            scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);
            transform.Translate(speed * Time.deltaTime * -1, 0, 0);
        }

    }
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
