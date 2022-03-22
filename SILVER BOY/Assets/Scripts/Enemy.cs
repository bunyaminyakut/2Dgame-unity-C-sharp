using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int can = 2;
    Rigidbody2D rb;
    public void takeDamage(int damage)
    {
        can -= damage;
        if (can <= 0)
        {
            ScoreScript.scoreNum += 10;
            Die();
        }

        void Die()
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gamer"))
        {
            
            collision.GetComponent<Gamer>().takemDamage(1);
            
        }



    }

}
