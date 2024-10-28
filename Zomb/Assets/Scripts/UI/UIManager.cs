using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text health;
    

    private HealthSystem healthSystem;
    private GameManager gameManager;
    private void Awake()
    {
        healthSystem = GameObject.FindWithTag("Player").GetComponent<HealthSystem>();
        //scoreText.text = GetComponent<TMP_Text>().text;
        //health.text = GetComponent<TMP_Text>().text;
        

    }
    private void Start()
    {
        //gameManager = GameManager.Instance;

    }
    private void Update()
    {

        //scoreText.text = GameManager.Instance.score.ToString();
        //health.text = healthSystem.CurrentHealth.ToString();


    }
}
