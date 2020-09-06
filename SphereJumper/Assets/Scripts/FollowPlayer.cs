using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position;
    }


    void Update()
    {
        transform.position = player.transform.position + offset;  
    }
}