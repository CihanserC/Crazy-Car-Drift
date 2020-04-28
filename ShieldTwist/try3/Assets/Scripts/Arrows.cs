using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Arrows : MonoBehaviour
{

    public GameObject Arrow;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        float ArrowSpeed = 1;


        float initialX = Random.Range(2, 7);
        float initialY = Random.Range(2, 5);
        transform.position = new Vector2(initialX, initialY);
        Debug.Log("Arrow created");


        //Instantiate(Arrow);

    }

    // Update is called once per frame

    void Update()
    {
        Vector2 direction = player.position - transform.position;

        transform.Translate(direction * Time.deltaTime);     




        //StartCoroutine(Delay());
        // yield return new WaitForSeconds(5);

        // float x = GameObject.FindGameObjectWithTag("Player").transform.position.x ;
        //float y = GameObject.FindGameObjectWithTag("Player").transform.position.y ;

        //transform.position = new Vector2(x, y);
    }
}

/*
IEnumerator Delay()
{
    //Print the time of when the function is first called.
    Debug.Log("Started Coroutine at timestamp : " + Time.time);

    //yield on a new YieldInstruction that waits for 5 seconds.
    yield return new WaitForSeconds(5);

    //After we have waited 5 seconds print the time again.
    Debug.Log("Finished Coroutine at timestamp : " + Time.time);
}

*/