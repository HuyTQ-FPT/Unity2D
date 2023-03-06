using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnInterval = 2f;
    public float spawnRange = 10f;

    private float timeSinceLastSpawn;

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