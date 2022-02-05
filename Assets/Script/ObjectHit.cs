using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("is it running");
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player"))
        {
            meshRenderer.material.color = new Color32(156, 124, 31,255);
            gameObject.tag = "Hit";
            
            
        }
    }

}
