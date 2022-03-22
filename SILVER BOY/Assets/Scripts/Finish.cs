using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public Text pointText;
    public static int point;

    [SerializeField] private AudioSource finishEffect;


    public void Start()
    {
        finishEffect.Play();
        point = ScoreScript.scoreNum;
        pointText.text = "Score : " + point;
    }
    public void Update()
    {

    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Start");
    }
}
