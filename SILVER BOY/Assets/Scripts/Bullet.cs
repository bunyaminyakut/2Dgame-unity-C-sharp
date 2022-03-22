using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Rigidbody2D rb;
    private float bulletSpeed=15;
    float endTime=1;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
        Destroy(gameObject, endTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")){

            collision.GetComponent<Enemy>().takeDamage(1);
            Destroy(gameObject);
        }
        

       
    }
}
