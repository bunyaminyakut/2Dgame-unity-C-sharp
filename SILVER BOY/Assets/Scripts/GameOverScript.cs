using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    
    public Text pointText;
    public static int point;

    [SerializeField] private AudioSource dieEffect;


    public void Start()
    {
        dieEffect.Play();
        point = ScoreScript.scoreNum;
        pointText.text = "Score : " + point;
    }
    public void Update()
    {
        
    }

  

    public void RestartButton()
    {
        SceneManager.LoadScene("Level2");

    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Start");
    }

}
