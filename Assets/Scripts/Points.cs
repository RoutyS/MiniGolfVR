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
    public Text txt;
    public int score = 0;
    void Start()
    {
        txt.text = score.ToString(); 
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
            score++;
            txt.text = score.ToString();
        }
    }
}
