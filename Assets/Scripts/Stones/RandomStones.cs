using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStones : MonoBehaviour
{
    public GameObject stock;
    public float spawnTime;
    float m_spawnTime;
    void Start()
    {
        m_spawnTime = 0;
    }
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_spawnTime < 0)
        {
            spawnBall();
            m_spawnTime = spawnTime;
        }
    }
    public void spawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-40, 40), 30);
        if (stock)
        {
            Instantiate(stock, spawnPos, Quaternion.identity);
        }
    }
}

