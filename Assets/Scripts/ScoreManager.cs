using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
  

    
    public TextMeshProUGUI txt;
    public int score = 0;
    private bool canScore = true;
   
  
    void Start()
    {
        txt.text = score.ToString();
    }

    void Update()
    {
        if (score == 6)
        {
            score = 0;
          
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trou")
        {
           
            score = 0;
            txt.text = score.ToString();
            GameManager.Instance.AddScore(score);
           
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "bout" && canScore)
        {
            
            ScoreIncrement();
        }
    }

    void ScoreIncrement()
    {
        score++;
        txt.text = score.ToString();
        canScore = false;
        Invoke("EnableScoring", 1f); // après 5 secondes, EnableScoring() sera appelé
    }

    void EnableScoring()
    {
        canScore = true;
    }
}