using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle;
    public float maxX;
    public float minX;
    public float minY;
    public float maxY;
    public float TimeBetweenSpawn;
    public float StartDelay;
    private float SpawnTime;
    private bool canSpawn = false;

    void Start()
    {
        Invoke("StartSpawning", StartDelay);
    }

    public void StartSpawning()
    {
        canSpawn = true;
    }

    void Update()
    {
        if (canSpawn && Time.time > SpawnTime)
        {
            SpawnTime = Time.time + TimeBetweenSpawn;
            Spawn();
        }
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxX);
        float Y = Random.Range(minY, maxY);
        Instantiate(Obstacle, transform.position + new Vector3(X, Y, 0), transform.rotation);

        // Yeni bir ObstacleSpawner nesnesi olu�turuldu�unda, StartDelay de�eri ayarlanacak.
        // Bu de�er ObstacleSpawner'�n bir sonraki spawn i�lemini ba�latmas� i�in gerekli olan gecikmeyi belirler.
        float newStartDelay = Random.Range(0f, 5f); // Ba�lang�� gecikmesini rastgele olarak ayarlay�n.
        Invoke("StartSpawning", newStartDelay);
    }
}
