using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

public class GameManager : MonoBehaviour
{
    public static int FallCounter = 0;

    public GameObject LevelWonUI;
    public GameObject GameOverUI;
    public PlayerController PlayerMovement; //??
    public ParticleSystem confetti;

    public ColorPicker cp;

    Renderer renderer;

    Material CurrMat;

    public void CheckFall() // Counts the falling to 3 times and then restarts it.
    {
        FallCounter++;
        //Debug.Log("Fall Count:"+ FallCounter);

        if (FallCounter < 3)
        {
            Restart();

        }
        else
        {
            GameOverMenu();
        }

    }

    public void GameOverMenu()
    {
        // Show Game over GUI
        //Debug.Log("GAME OVER!");
        GameOverUI.SetActive(true);

        //PlayerMovement.enabled = false;
        PauseGame();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //PlayerMovement.enabled = true;
        Time.timeScale = 1;

    }

    public void LevelWon()
    {
        // Give 2.5 second delay

        //Debug.Log("Level Won!");
        Invoke("PauseGame", 3);
        LevelWonUI.SetActive(true);
    
        //PauseGame();

        //PlayerMovement.enabled = false;
    }

    public void ExitStore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
        Time.timeScale = 1;

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void PlayGameButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;

   
    }

    public void GotoMenuButton()
    {
        SceneManager.LoadScene("Menu");

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application has closed!");
    }

    public void StoreButton()
    {
        SceneManager.LoadScene("Store");

    }


}
