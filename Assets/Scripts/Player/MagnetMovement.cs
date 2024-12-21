using UnityEngine;

public class MagnetMovement : MonoBehaviour
{
    [SerializeField] private Transform magnet1;
    [SerializeField] private Transform magnet2;
    [SerializeField] private float _fallSpeed;
    

    private bool isSelected = false;

    private int sayi;
    public bool dif;

    public float moveSpeed = 5f;

    public GameObject camera;

    void Update()
    {

        transform.position += Vector3.down * _fallSpeed * Time.deltaTime;
        


        if (camera.activeSelf)
        {
            dif = true;
        }
        else
        {
            dif = false;
        }

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


        if (isSelected && dif == true)
        {
            if (sayi == 1)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    magnet1.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    magnet1.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                }
            }

            if (sayi == 0)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    magnet2.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    magnet2.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                }
            }

        }

        if (isSelected && dif == false)
        {
            if (sayi == 1)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    magnet1.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.D))
                {
                    magnet1.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
                }
            }

            if (sayi == 0)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    magnet2.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.D))
                {
                    magnet2.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
                }
            }
        }


    }


}




