using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
  

    public TextMeshProUGUI nbCoupText;
    public int nbCoup ;


    private void Start()
    {
        nbCoup = 0;
    }

    void Update()
    {
        /*nbCoupText.text = nbCoup.ToString();*/
    }

   
}