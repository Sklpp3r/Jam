using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 10f;
    

    public float forceDuration = 2f;
    private float elapsedTime = 0f;

  
    void Update()
    {
       

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * forceAmount);
                elapsedTime += Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * forceAmount);
                elapsedTime += Time.deltaTime;
            }

        
        
    }

}
