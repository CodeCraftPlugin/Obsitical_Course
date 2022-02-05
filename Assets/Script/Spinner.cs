using System;
using UnityEngine;

namespace Script
{
    public class Spinner : MonoBehaviour
    {
        [SerializeField] float xAngle = 0f;
        [SerializeField] float yAngle = 10f;
        [SerializeField] float zAngle = 0f;
        [SerializeField] float speed = 10f;
        private void Update()
        { 
             
            transform.Rotate(xAngle*Time.deltaTime*speed,yAngle*Time.deltaTime*speed,zAngle*Time.deltaTime*speed);
        }
    }
}