using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class OyunSkor : MonoBehaviour
{
   
    public TMP_Text scoreText;
    public ScoreManagment scoreManager;
    private void Update()
    {



        scoreText.text = "Score: " + scoreManager.score;
    }

}
