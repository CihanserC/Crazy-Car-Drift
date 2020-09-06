using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    public AudioSource BallJump;

    public void PlayBallJump()
    {
        BallJump.Play();
    }
}
