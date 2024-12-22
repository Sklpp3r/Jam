using UnityEngine;

public class RopeControllerWithLineRenderer : MonoBehaviour
{
    public Transform magnet;  // Mıknatısın bağlı olduğu nokta
    public Transform chest;   // Sandığın bağlı olduğu nokta
 // LineRenderer bileşeni
    public float moveSpeed = 5f; // Sandık hareket hızı

    void Start()
    {

    }

    void Update()
    {
        // Sandığın hareketini kontrol et
        float moveDirection = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection = -1f; // Sol
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection = 1f; // Sağ
        }

        // Sandığı hareket ettir
        chest.position += new Vector3(moveDirection * moveSpeed * Time.deltaTime, 0f, 0f);

    }
}
