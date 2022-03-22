using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    Rigidbody2D rb;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gamer"))
        {

            collision.GetComponent<Gamer>().takemDamage(3);

        }



    }

}
