using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marbel : MonoBehaviour
{
    private static Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Convert.ToInt32(Time.time));
        if (Time.time >= 15f)
        {
            Rigidbody.useGravity = true;
        }
    }
}
