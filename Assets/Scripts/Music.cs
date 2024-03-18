using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource grenlb1b;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            grenlb1b.Play();
        }
    }
}
