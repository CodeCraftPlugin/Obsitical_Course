using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Dropper : MonoBehaviour
    {
        private static float time;
        
        public static Rigidbody Rigidbody;
        public static MeshRenderer MeshRenderer;
        private void Start()
        {
            Rigidbody = GetComponent<Rigidbody>();
            MeshRenderer = GetComponent<MeshRenderer>();
            MeshRenderer.enabled = false;
            Rigidbody.useGravity = false;
        }

        private void Update()
        {
            time = Time.time;
            if (time >= 15.0f)
            {
                Rigidbody.useGravity = true;
                MeshRenderer.enabled = true;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            Rigidbody.useGravity = false;
        }
    }
}