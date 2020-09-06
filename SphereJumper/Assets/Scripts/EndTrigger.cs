using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;
    public GameObject Confetti;

    public void OnTriggerEnter(Collider other)
    {
        // Give confetti effect.
        Confetti.SetActive(true);

        GameManager.LevelWon();
    }

   
}
