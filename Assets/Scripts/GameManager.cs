using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject Enemy2Prefab;
    public GameObject Enemy3Prefab;
    public GameObject Enemy4Prefab;
    public GameObject Enemy5Prefab;
    public Transform[] EnemySpawnPoints;
    public Transform[] EnemySpawnPoints2;
    public Transform[] EnemySpawnPoints3;
    public Transform[] EnemySpawnPoints4;
    public Transform[] EnemySpawnPoints5;

    private float timeRemaining;
    public float spawnDelay;
    public TextMeshPro timerText;
    private Timer timer;


  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, 4);
        InvokeRepeating("SpawnEnemy2", 4, 7);
        InvokeRepeating("SpawnEnemy3", 6, 4);
        InvokeRepeating("SpawnEnemy4", 8, 3);
        InvokeRepeating("SpawnEnemy5", 10, 2);
        timer = GetComponent<Timer>();
        timeRemaining = spawnDelay;

;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timerIsRunning)
        {
            timerText.text = timer.GetTimeForDisplay();
        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            timeRemaining = spawnDelay;
        }

        
    }

    void SpawnEnemy()
    {
            int index = Random.Range(0, EnemySpawnPoints.Length);
            Vector3 spawPos = EnemySpawnPoints[index].position;
            GameObject Enemy = Instantiate(EnemyPrefab, spawPos, Quaternion.identity);
            
            int dirModifier = 1;

        Enemy.GetComponent<Enemy>().speed = Random.Range(0.5f, 1.5f) * dirModifier;
    }

    void SpawnEnemy2()
    {
        int index = Random.Range(0, EnemySpawnPoints2.Length);
        Vector3 spawPos2 = EnemySpawnPoints2[index].position;
        GameObject Enemy2 = Instantiate(Enemy2Prefab, spawPos2, Quaternion.identity);

        int dirModifier = 1;

        Enemy2.GetComponent<Enemy>().speed = Random.Range(1.0f, 1.5f) * dirModifier;
    }

    void SpawnEnemy3()
    {
        int index = Random.Range(0, EnemySpawnPoints3.Length);
        Vector3 spawPos3 = EnemySpawnPoints3[index].position;
        GameObject Enemy3 = Instantiate(Enemy3Prefab, spawPos3, Quaternion.identity);

        int dirModifier = 1;

        Enemy3.GetComponent<Enemy>().speed = Random.Range(1.5f, 2.0f) * dirModifier;
    }

    void SpawnEnemy4()
    {
        int index = Random.Range(0, EnemySpawnPoints4.Length);
        Vector3 spawPos4 = EnemySpawnPoints4[index].position;
        GameObject Enemy4 = Instantiate(Enemy4Prefab, spawPos4, Quaternion.identity);

        int dirModifier = 1;

        Enemy4.GetComponent<Enemy>().speed = Random.Range(2.0f, 2.5f) * dirModifier;
    }



    void SpawnEnemy5()
    {
        int index = Random.Range(0, EnemySpawnPoints5.Length);
        Vector3 spawPos5 = EnemySpawnPoints5[index].position;
        GameObject Enemy5 = Instantiate(Enemy5Prefab, spawPos5, Quaternion.identity);

        int dirModifier = 1;

        Enemy5.GetComponent<Enemy>().speed = Random.Range(2.5f, 3.0f) * dirModifier;
    }



}
