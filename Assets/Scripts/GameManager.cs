using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int ScoreFinale= 0; 

    void Awake()
    {
        // Vérifier s'il y a déjà une instance de GameManager.
        if (Instance == null)
        {
          
            Instance = this;
        }
        else
        {
           
            Destroy(gameObject);
        }

        
        DontDestroyOnLoad(gameObject);
    }

  
    public void AddScore(int score)
    {
        ScoreFinale += score;
    }

  
    public void ResetFinalScore()
    {
        ScoreFinale = 0;
    }

  
    public int GetFinalScore()
    {
        return ScoreFinale;
    }
}
