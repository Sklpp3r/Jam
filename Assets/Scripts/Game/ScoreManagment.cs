using TMPro;
using UnityEngine;
 

public class ScoreManagment : MonoBehaviour
{
    public TMP_Text scoreText;

    public float ball;
        
   float score = 0f; 
    void Update()
    {
        score += Time.deltaTime * ball;
        
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
    }
    
}
