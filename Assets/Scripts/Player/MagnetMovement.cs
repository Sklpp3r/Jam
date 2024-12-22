using UnityEngine;

public class MagnetMovement : MonoBehaviour
{
    [SerializeField] private Transform magnet1;
    [SerializeField] private Transform magnet2;
    [SerializeField] private float _fallSpeed;


    private bool isSelected = false;
    private int sayi;

    public float moveSpeed = 5f;



    void Update()
    {

        transform.position += Vector3.down * _fallSpeed * Time.deltaTime;




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


        if (isSelected == true)
        {
            if (sayi == 1)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    magnet1.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.World);
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    magnet1.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);
                }
            }

            if (sayi == 0)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    magnet2.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.World);
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    magnet2.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);
                }
            }

        }






    }


}




