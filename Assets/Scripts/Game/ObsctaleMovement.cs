using UnityEngine;

public class ObsctaleMovement : MonoBehaviour
{
    [SerializeField] private float _obstacleSpeed;

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
    }

}
