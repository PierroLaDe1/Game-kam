using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour

{
    void Start()
    {
        InvokeRepeating("LaunchProjectile", 1f, 0.1f);
    }

    Vector3 vectorDirection = new Vector3(0f, 0f, 1f);

    void LaunchProjectile()
    {
        if (Physics.Raycast(transform.position, vectorDirection, 2f, LayerMask.GetMask("Well")))
        {
            vectorDirection = -vectorDirection;
        }
        else
        {
            transform.position += vectorDirection;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    //start is called before the first frame update

}

