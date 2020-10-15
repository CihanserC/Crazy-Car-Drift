using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    bool GameEnded = false;
    public float restartDelay = 2f;
    public GameObject LevelCompletedUI;
    public GameObject GameOverUI;

    //public GameObject player;

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

}
