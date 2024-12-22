using UnityEngine;

public class LineRenderforChest : MonoBehaviour
{
    public Transform leftMagnet;  // Sol mıknatıs
    public Transform rightMagnet; // Sağ mıknatıs
    public Transform chest;       // Sandık
    public LineRenderer lineRenderer; // LineRenderer bileşeni
    public float zOffset = 0.1f;  // Çizgi ile nesneler arasındaki z ofseti

    [SerializeField] private float BaslangicKalinligi;
    [SerializeField] private float BitisKalinligi;
    [SerializeField] private int NoktaAyari;

    public float raycastDistance = 10f; // Raycast mesafesi
    public string IpObjesi = "IpObjesi"; // Görülen objelerin sahip olması gereken tag



    void Start()
    {
        // LineRenderer'ın noktalarını ayarla
        lineRenderer.positionCount = 3;

        // Çizgi kalınlıklarını ayarla
        lineRenderer.startWidth = BaslangicKalinligi; // Başlangıç kalınlığı
        lineRenderer.endWidth = BitisKalinligi;   // Bitiş kalınlığı
    }

    void Update()
    {
        // LineRenderer'ı güncelle
        UpdateLineRenderer();
    }

    void UpdateLineRenderer()
    {
        // Sol mıknatıs ve sağ mıknatıs arasındaki çizgiyi oluştur
        Vector3 leftMagnetPosition = leftMagnet.position + new Vector3(0, 0, zOffset);
        Vector3 rightMagnetPosition = rightMagnet.position + new Vector3(0, 0, -zOffset);


        // Raycast ile X ekseninde engel olup olmadığını kontrol et
        RaycastHit hit;
        if (Physics.Raycast(leftMagnetPosition, Vector3.right, out hit, raycastDistance))
        {
            // Eğer objenin tag'i "Obstacle" ise, çizgiyi durdur
            if (hit.collider.CompareTag(IpObjesi))
            {
                // Engel varsa, sağ mıknatısın pozisyonunu engel noktasına göre ayarla
                rightMagnetPosition = hit.point;
            }
        }




        // Mıknatısların pozisyonlarına ve sandığa ofset ekleyerek çizgiyi ayarla
        lineRenderer.SetPosition(0, leftMagnet.position + new Vector3(0, 0, zOffset)); // Sol mıknatıs pozisyonuna ofset ekle
        lineRenderer.SetPosition(1, chest.position + new Vector3(0, 0, zOffset));      // Sandığa ofset ekle (içeri girmesini engelle)
        lineRenderer.SetPosition(2, rightMagnet.position + new Vector3(0, 0, -zOffset)); // Sağ mıknatıs pozisyonuna ofset ekle
    }
}
