using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text myScoreText;
    public static int scoreNum;
    // Start is called be1fore the first frame update
    void Start()
    {
        scoreNum = 0;
        

    }
    private void Update()
    {
        myScoreText.text = "Score : " + scoreNum;
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            scoreNum += 10;
            myScoreText.text = "Score : " + scoreNum;
        }
    }


}
