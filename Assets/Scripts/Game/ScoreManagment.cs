using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManagment : MonoBehaviour
{
    public TMP_Text scoreText;
    public Canvas Canvazz;

    public float ball;

    public float score = 0f;
    void Update()
    {



        score += Time.deltaTime * ball;

        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();

        if (ball == 0)
        {
            Canvazz.enabled = true;
             }

    }

}
