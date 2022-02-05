using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed  = 9.0f;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("System Call Loading Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float z = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.Translate(x,0,z);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Hit")){score++;}
        Debug.Log("you have bumped in object this many time: "+score);
    }
}
