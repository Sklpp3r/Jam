using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 10f;
    

    public float forceDuration = 2f;
    private float elapsedTime = 0f;

  
    void Update()
    {
        if (elapsedTime < forceDuration)
        {


            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * forceAmount, ForceMode.Force);
                elapsedTime += Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * forceAmount, ForceMode.Force);
                elapsedTime += Time.deltaTime;
            }

        }
        
    }

}
