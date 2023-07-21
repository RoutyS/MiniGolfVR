using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreFinale : MonoBehaviour
{
    public Text scoref;

    void Update()
    {
        scoref.text = "Score final:" + GameManager.Instance.GetFinalScore().ToString();
    }
}
