using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplatandüsman : MonoBehaviour
{
    private float Zıplamakuvveti = 15f;

    public void OnCollisionEnter2D(Collision2D temas)
    {
        Rigidbody2D rb = temas.collider.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 Zıplamavelocity = rb.velocity;
            Zıplamavelocity.y = Zıplamakuvveti;
            rb.velocity = Zıplamavelocity;
        }
    }
}
