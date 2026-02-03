using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
 
    public Transform targer;
    float speed = 5f;
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
       // Debug.Log(Time.deltaTime);
        transform.position += new Vector3 (h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);
    }
}
