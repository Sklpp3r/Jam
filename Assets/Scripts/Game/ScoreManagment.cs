using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManagment : MonoBehaviour
{
    public TMP_Text scoreText;

    public float ball;

    public float score = 0f;
    void Update()
    {

        if (ball == 0)
        {
            SceneManager.LoadScene(0);
        }


        score += Time.deltaTime * ball;

        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
    }

}
