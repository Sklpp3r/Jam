using UnityEngine;

public class MagnetMovement : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private Transform magnet1;
    [SerializeField] private Transform magnet2;
    private bool isSelected = false;
    private float zCoordinate;

    private int sayi;
    
    
    public float moveSpeed = 5f;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isSelected = true;
            sayi = 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isSelected = true;
            sayi = 0;
        }
        

        // Eğer obje seçildiyse, hareket ettirme işlemi yapılır
        if (isSelected)
        {
            // W ve S tuşlarına basıldığında hareket et
            if (sayi == 1)
            {
                if (Input.GetKey(KeyCode.W)) // W tuşuna basıldığında yukarı hareket et
                {
                    magnet1.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.S)) // S tuşuna basıldığında aşağıya hareket et
                {
                    magnet1.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                }
            }

            if (sayi == 0)
            {
                if (Input.GetKey(KeyCode.W)) // W tuşuna basıldığında yukarı hareket et
                {
                    magnet2.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                }
                
                if (Input.GetKey(KeyCode.S)) // S tuşuna basıldığında aşağıya hareket et
                {
                    magnet2.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                }  
            }

        }
    }
    
    
}




