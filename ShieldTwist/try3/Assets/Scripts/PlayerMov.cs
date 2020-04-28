using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMov : MonoBehaviour{


    public GameObject Player;

    float x=0;
    float y=0;

    Vector2 PlayerVector = new Vector2(0,0);


    public int movementspeed = 10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate( Vector2.up * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * movementspeed * Time.deltaTime);
        }
    }
}