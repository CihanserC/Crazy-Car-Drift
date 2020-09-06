using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{
    public ColorPicker color;

    public void OnTriggerEnter(Collider other)
    {
        color.LoadChanges();
    }
}
