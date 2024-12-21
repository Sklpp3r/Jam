using TMPro;
using UnityEngine;
 

public class ScoreManagment : MonoBehaviour
{
    public TMP_Text scoreText;

    public int ball;
        
   float score = 0f; 
    void Start()
    {
        
    }

    void Update()
    {
        score += Time.deltaTime * ball;
        
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
    }
}
