using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject CompleteLevelUI;
   public void EndGame()
    {

        if(GameHasEnded == false)
        {
            Debug.Log("Game Over!");
            GameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    
    }
    public void CompleteLevel()
    {
        Debug.Log("Level Won!");
        CompleteLevelUI.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}
