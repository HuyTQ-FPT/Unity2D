using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectPrefab;
    public float spawnInterval = 6f;
    public float spawnRange = 10f;

    private float timeSinceLastSpawn;

    void Start()
    {
        StartCoroutine(DecreaseValue());
    }

    IEnumerator DecreaseValue()
    {
        while (spawnInterval > 2)
        {
            yield return new WaitForSeconds(15f);
            spawnInterval--;
        }
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            timeSinceLastSpawn = 0f;

            Vector2 spawnPosition = GetRandomSpawnPosition();

            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        }
    }

    private Vector2 GetRandomSpawnPosition()
    {
        float cameraHeight = Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        float x = Random.Range(-spawnRange, spawnRange);
        float y = Random.Range(-spawnRange, spawnRange);

        if (x > 0 && x < cameraWidth)
        {
            x += cameraWidth;
        }
        else if (x < 0 && x > -cameraWidth)
        {
            x -= cameraWidth;
        }

        if (y > 0 && y < cameraHeight)
        {
            y += cameraHeight;
        }
        else if (y < 0 && y > -cameraHeight)
        {
            y -= cameraHeight;
        }

        return new Vector2(x, y);
    }
}
