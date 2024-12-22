using UnityEngine;

public class ObsctaleMovement : MonoBehaviour
{
    [SerializeField] private float _obstacleSpeed;
    
    public ScoreManagment scoreM;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void Update()
    {

        transform.position += Vector3.down * _obstacleSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        { 
            Destroy(gameObject);
        }

        if (other.CompareTag("Player"))
        {
            scoreM.score -= 100;
        }
    }

}
