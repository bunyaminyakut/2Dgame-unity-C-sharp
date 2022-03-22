using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamer : MonoBehaviour
{


    public int can =1;
    public int Ziplatmagucu = 20;
    public GameObject[] hearts;
    [SerializeField] private AudioSource damageSoundEffect;
    Rigidbody2D rb;

    [SerializeField] private AudioSource collectEffect;
    

    public void takemDamage(int damage)
    {
        can -= damage;
        if (can == 0)
        {
            
            Die();
            SceneManager.LoadScene("Gameover");
        }
        else if(can==2)
        {
            damageSoundEffect.Play();
            Destroy(hearts[2].gameObject);
        }
        else if (can == 1)
        {
            damageSoundEffect.Play();
            Destroy(hearts[1].gameObject);
        }
        


        void Die()
        {
        
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin")){

            collectEffect.Play();
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Fin"))
        {
            SceneManager.LoadScene("Finish");
        }
       
        
    }

}
