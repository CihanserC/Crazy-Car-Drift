using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletedMenu : MonoBehaviour
{
    public void RetryLevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }

    public void GotoMainMenu(){

		SceneManager.LoadScene(0);

    }

    public void NextLevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }
}
