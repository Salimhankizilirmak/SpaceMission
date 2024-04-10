using UnityEngine;
public class PlayerMove : MonoBehaviour
{

    public enum GemiTipi { Player1, Player2 }
    public GemiTipi gemiTipi;
    private Vector3 respawnPoint;
    public float hiz; // Geminin h�z�

    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    private void Update()
    {
      

        float hareketYonu = 0.0f;
        

        // Birinci gemi i�in W-S kontrolleri
        if (gemiTipi == GemiTipi.Player1)
        {

            if (Input.GetKey(KeyCode.W))
            {

                hareketYonu = 1.0f;
            }
            else if (Input.GetKey(KeyCode.S))
            {

                hareketYonu = -1.0f;
            }
        }
        // �kinci gemi i�in Up-Down kontrolleri
        else if (gemiTipi == GemiTipi.Player2)
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {

                hareketYonu = 1.0f;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {

                hareketYonu = -1.0f;
            }

        }

       

        // Yukar�/a�a�� hareketi uygula
        rb.velocity = new Vector2(0.0f, hareketYonu * hiz);


    }
}