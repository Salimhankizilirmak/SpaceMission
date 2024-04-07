using UnityEngine;

public class RePlay : MonoBehaviour
{
    public GameObject GameOverPanel;
    private Life lifeScript;
    public GameObject player1Prefab; // Oyuncu 1 için prefab
    public GameObject player2Prefab; // Oyuncu 2 için prefab

    void Start()
    {
        lifeScript = GameObject.FindGameObjectWithTag("LifeManager").GetComponent<Life>();
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player1") == null && lifeScript.GetLife() >= 3)
        {
            RespawnPlayer(player1Prefab);
            lifeScript.ReduceLife();
        }
        else if (GameObject.FindGameObjectWithTag("Player2") == null && lifeScript.GetLife() >= 3)
        {
            RespawnPlayer(player2Prefab);
            lifeScript.ReduceLife();
        }
    }

    void RespawnPlayer(GameObject playerPrefab)
    {
        // Respawn pozisyonunu bul
        Vector3 respawnPosition = GetRespawnPosition();

        // Oyuncuyu yeniden doður
        Instantiate(playerPrefab, respawnPosition, Quaternion.identity);
    }

    Vector3 GetRespawnPosition()
    {
        // Tüm oyuncu GameObject'lerini bul
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        // Herhangi bir oyuncunun PlayerController bileþenini al ve respawnPoint'i al
        foreach (GameObject player in players)
        {
            PlayerController playerController = player.GetComponent<PlayerController>();
            if (playerController != null)
            {
                return playerController.GetRespawnPoint();
            }
        }

        // Eðer respawnPoint bulunamazsa, varsayýlan olarak (0, 0, 0) konumunu dön
        return Vector3.zero;
    }
}
