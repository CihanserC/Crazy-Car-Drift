using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{

    bool GameEnded = false; 
    private bool isPaused = false;

    public float restartDelay = 2f;
    public GameObject LevelCompletedUI;
    public GameObject GameOverUI;
    public GameObject PauseGameUI;

    //public GameObject player;

    public void PauseGame()
    {
        isPaused = !isPaused;

        if(isPaused == true)
        {
            PauseGameUI.SetActive(true);
            Time.timeScale = 0; // Freeze the game
            //isPaused = false;
        }
        else
        {
            PauseGameUI.SetActive(false);
            Time.timeScale = 1; // Continue to the game
            //isPaused = true;
        }
    }
    public void EndGame()
    {
        if(GameEnded == false)
        {
            Debug.Log("Game Over!");
            GameEnded = true;
            Invoke("Restart", restartDelay);
        }
    
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag=="Finish")
        {

            Debug.Log("Level Won!");
            LevelCompletedUI.SetActive(true);
        }

        if(col.tag=="Obstacle")
        {

            Debug.Log("You Lost!");
            GameOverUI.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RetryLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GotoMainMenu()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }

    public void NextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
