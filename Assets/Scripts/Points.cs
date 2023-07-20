using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
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
            cube.SetActive(false);
        }
        if (collision.gameObject.tag == "bout")
        {
            
        }
    }
}
