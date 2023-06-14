using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public GameObject restartPanel;

    public TMP_Text timerDisplay;

    private bool hasLost;

    public float timer;

    public int levelID;

    private void Update() 
    {

        
        if(hasLost == false)
        {
        timerDisplay.text = timer.ToString("F0");    
        }

        if(timer <= 0)
        {
            SceneManager.LoadScene(levelID);
        }
        else {
            timer -= Time.deltaTime;
        }
        
    }

    public void GameOver()
    {
        hasLost = true;
       Invoke("Delay", 1.5f);
    }

    void Delay()
    {
        restartPanel.SetActive(true);
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
