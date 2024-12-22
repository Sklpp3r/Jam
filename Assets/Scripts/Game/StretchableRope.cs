using UnityEngine;

public class RopeController : MonoBehaviour
{
    public Transform magnet;  // Mıknatısın bağlı olduğu nokta
    public Transform chest;   // Sandığın bağlı olduğu nokta
    public Transform[] bones; // İpi oluşturan bone'lar
    public float ropeLength = 5f; // Başlangıç ip uzunluğu
    public float minLength = 2f;  // Minimum uzunluk
    public float maxLength = 10f; // Maksimum uzunluk
    public float adjustSpeed = 2f; // Uzatma/kısaltma hızı

    void Update()
    {
        // Kullanıcı girişlerini kontrol et
        if (Input.GetKey(KeyCode.A) && ropeLength > minLength)
        {
            ropeLength -= adjustSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) && ropeLength < maxLength)
        {
            ropeLength += adjustSpeed * Time.deltaTime;
        }

        UpdateRope();
    }

    void UpdateRope()
    {
        float segmentLength = ropeLength / (bones.Length - 1);

        for (int i = 0; i < bones.Length; i++)
        {
            if (i == 0)
            {
                bones[i].position = magnet.position; // İlk bone mıknatısa bağlı
            }
            else if (i == bones.Length - 1)
            {
                bones[i].position = chest.position; // Son bone sandığa bağlı
            }
            else
            {
                Vector3 direction = (chest.position - magnet.position).normalized;
                bones[i].position = magnet.position + direction * segmentLength * i;
            }
        }
    }
}
