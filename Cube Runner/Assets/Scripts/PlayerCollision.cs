using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GameManager gamemanager;

    public GameObject GameOverUI;
    public GameObject LevelCompletedUI;


    private void OnCollisionEnter(Collision col)
    {

        if(col.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false;

            GameOverUI.SetActive(true);
           // FindObjectOfType<GameManager>().EndGame();

        }
        else if(col.collider.tag == "Finish Line")
        {
            Debug.Log("Level Won!");
            movement.enabled = false;
            LevelCompletedUI.SetActive(true);
        }


    }
}
