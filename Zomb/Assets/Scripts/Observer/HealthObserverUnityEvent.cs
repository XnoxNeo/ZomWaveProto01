using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthObserverUnityEvent : MonoBehaviour
{
    [SerializeField] private string levelName = "MainMenu";


    public void OnHealthDepleted()
    {
        SceneManager.LoadScene(levelName);
    }


}
