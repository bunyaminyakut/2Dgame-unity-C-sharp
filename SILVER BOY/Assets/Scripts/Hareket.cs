using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

    Rigidbody2D rb;

    public Animator animator;


    public float horizontalMove;
    public int moveSpeed;
    public int jumpSpeed;

    public bool floorTouch = true;
    public bool faceright = true;

    [SerializeField] private AudioSource jumpSoundEffect;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalMove * moveSpeed * 100 * Time.deltaTime, rb.velocity.y);

     

        if(Input.GetKeyDown(KeyCode.Space) && floorTouch == true)//space tu�una bast���nda karakter yerdeyse z�pla
        {
             
            jumpSoundEffect.Play();
            animator.SetTrigger("takeOf");
     
            rb.velocity = Vector2.up * jumpSpeed * 100 * Time.deltaTime;
            floorTouch = false;
        }

        if(floorTouch == true)// z�plama animasyonunun �al��mas� i�in
        {
            animator.SetBool("IsJumping", false);
        }
        else
        {
            animator.SetBool("IsJumping", true);
        }

        if(horizontalMove > 0 && faceright== false)
        {
            turn();
        }
        if (horizontalMove < 0 && faceright == true)
        {
            turn();
        }
         
        if (horizontalMove == 0)   // Yatay hareket olunca y�r�me animasyonunu devreye sokma
        {
            animator.SetBool("IsRunning", false);
        }
        else { 
        
            animator.SetBool("IsRunning", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)// karakter yere de�ip de�memesi kontrol
    {
        if(collision.gameObject.tag == "floor")
        {
            floorTouch = true;
        }
    }


    void turn()// karakterin y�z�n�n sa�a sola bakmas� i�in fonksiyon
    {
        faceright = !faceright;
        /*Vector2 newscale = transform.localScale;
        newscale.x *= -1;
        transform.localScale = newscale;*/
        transform.Rotate(new Vector3(0, 180, 0));
         
    }


}
