using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called before the first frame update

    float timerCounter = 0;
    
    
    void Start()
    {
        float timerCounter = Time.deltaTime;
    }

    float RotationSpeed;
    float Angle;
    float radius=2;

    // Update is called once per frame


    void Update()
    {
        timerCounter += Time.deltaTime;


        float x = GameObject.FindGameObjectWithTag("Player").transform.position.x + radius * Mathf.Cos(timerCounter);
        float y = GameObject.FindGameObjectWithTag("Player").transform.position.y + radius * Mathf.Sin(timerCounter);




        transform.position = new Vector2(x,y);
    }
}
