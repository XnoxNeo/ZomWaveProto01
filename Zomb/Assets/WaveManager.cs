using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [Header("Factories")]
    [SerializeField] private List<AbstractFactory> factoryList = new List<AbstractFactory>();


    public int enemiesPerWave = 5;     
    public float timeBetweenWaves = 5f;  
    private int currentWave = 0;         

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    private IEnumerator SpawnWaves()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenWaves);

            for (int i = 0; i < enemiesPerWave; i++)
            {
                SpawnEnemy();
            }
            currentWave++;
        }
    }

    private void SpawnEnemy()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(0f, 5f), Random.Range(0f, 5f));

        int random = Random.Range(0, factoryList.Count-1);
        Enemy enemy = factoryList[(int)random].CreateEnemy(spawnPosition);
    }
}
