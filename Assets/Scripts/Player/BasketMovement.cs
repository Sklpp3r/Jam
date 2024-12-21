using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * forceAmount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * forceAmount);
        }
    }

}
