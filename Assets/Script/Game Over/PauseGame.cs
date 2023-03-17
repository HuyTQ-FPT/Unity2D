using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject SpanwItems;
    public GameObject SpawnGun;
    public GameObject SpawnEnemy;
    public GameObject GenerateStones;
    public GameObject Pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("Oke");
            SpanwItems.SetActive(false);
            SpawnGun.SetActive(false);
            SpawnEnemy.SetActive(false);
            GenerateStones.SetActive(false);
            Time.timeScale = 1;
            Pause.SetActive(true);
        }
    }
    public void Continue()
    {
        Pause.SetActive(false);
        SpanwItems.SetActive(true);
        SpawnGun.SetActive(true);
        SpawnEnemy.SetActive(true);
        GenerateStones.SetActive(true);
    }
}
