using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class B : MonoBehaviour
{
    public Material material;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        material.color = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
/*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Cube"))
        {
            Debug.Log("OnCollisionEnter");
            material.color = Color.red;
        }
       
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Debug.Log("OnCollisionStay");
            material.color = Color.green;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Debug.Log("OnCollisionExit");
            material.color = Color.blue;
        }
    }
*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Debug.Log("OnCollisionEnter");
            material.color = Color.red;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Debug.Log("OnCollisionStay");
            material.color = Color.green;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Debug.Log("OnCollisionExit");
            material.color = Color.blue;
        }
    }


}
