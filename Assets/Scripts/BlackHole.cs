using System.Collections;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public CircleCollider2D redButtonCollider; // Kırmızı buton
    public CircleCollider2D blackHoleCollider; // Kara delik
    private GameObject Player1;
    private GameObject Player2;

    public float blackHoleDisappearTime = 10f; // Kara deliğin kaybolma süresi
    public AudioSource collisionSound; // Önceden atanmış patlama sesi dosyası

    private void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        collisionSound = GetComponent<AudioSource>(); // AudioSource bileşenini al
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(gameObject); // Sınırla çarpışırsa kendisini yok et
        }
        else if (collision.tag == "Player1" || collision.tag == "Player2")
        {
            Destroy(Player1.gameObject);
            Destroy(Player2.gameObject); 
            collisionSound.Play(); // Patlama sesini çal
        }
        else if (collision.tag == "RedButton")
        {
            StartCoroutine(DisappearBlackHole());
            Destroy(blackHoleCollider.gameObject); // Kırmızı butona çarparsa kara deliği yok etme işlemini başlat
        }
    }

    private IEnumerator DisappearBlackHole()
    {
        // Kara deliği yavaşça küçülterek yok etmek için boyut değişimi
        Vector3 initialScale = blackHoleCollider.transform.localScale;
        float elapsedTime = 0f;
        while (elapsedTime < blackHoleDisappearTime)
        {
            // Geçen süreye göre bir interpolasyon hesapla
            float t = elapsedTime / blackHoleDisappearTime;

            // Kara deliğin boyutunu güncelle
            blackHoleCollider.transform.localScale = Vector2.Lerp(initialScale, Vector2.zero, t);

            // Bir sonraki adıma geçmeden önce zamanı güncelle
            elapsedTime += Time.deltaTime;
            yield return null; // Bir sonraki frame'de devam et
        }

        // Kara deliği tamamen yok et
        Destroy(gameObject);
    }
}
