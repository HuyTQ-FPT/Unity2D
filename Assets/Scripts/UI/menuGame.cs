using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject text;
    public Button Play;
    public GameObject SpanwItems;
    public GameObject SpawnGun;
    public GameObject SpawnEnemy;
    public GameObject GenerateStones;
    public GameObject ContinueGame;
    public GameObject PauseGames;

    public void PlayGame()
    {
        //SpanwItems.SetActive(true);
        //SpawnGun.SetActive(true);
        //SpawnEnemy.SetActive(true);
        //GenerateStones.SetActive(true);
        PauseGames.SetActive(true);
        Time.timeScale = 1;
        ContinueGame.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseGames.SetActive(false);
        ContinueGame.SetActive(true);
    }

    public void ReStartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Character");
    }
}
