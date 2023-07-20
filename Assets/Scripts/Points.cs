using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trou")
        {
            cube.SetActive(true);
        }
    }
}
