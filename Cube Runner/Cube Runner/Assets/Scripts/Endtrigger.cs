using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OntriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
