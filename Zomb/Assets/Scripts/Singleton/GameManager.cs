using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
   
    public int score = 0;

    private void Awake()
    {
        
        if (Instance != null && Instance != this)
        {
            Destroy(this);

        }
        else
        {
            Instance = this;
        }
        //DontDestroyOnLoad(this.gameObject);
    }

    public void AddScore(int scoreAdd)
    {
        score += scoreAdd;
    }
    
}
