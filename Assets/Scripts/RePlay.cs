using UnityEngine;

public class RePlay : MonoBehaviour
{
    public GameObject GameOverPanel;
    private Life lifeScript;
    public GameObject player1Prefab; // Oyuncu 1 i�in prefab
    public GameObject player2Prefab; // Oyuncu 2 i�in prefab

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

        // Oyuncuyu yeniden do�ur
        Instantiate(playerPrefab, respawnPosition, Quaternion.identity);
    }

    Vector3 GetRespawnPosition()
    {
        // T�m oyuncu GameObject'lerini bul
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        // Herhangi bir oyuncunun PlayerController bile�enini al ve respawnPoint'i al
        foreach (GameObject player in players)
        {
            PlayerController playerController = player.GetComponent<PlayerController>();
            if (playerController != null)
            {
                return playerController.GetRespawnPoint();
            }
        }

        // E�er respawnPoint bulunamazsa, varsay�lan olarak (0, 0, 0) konumunu d�n
        return Vector3.zero;
    }
}
