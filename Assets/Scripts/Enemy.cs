using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform[] spawnpoint;

    public float spwaninterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpanRandomEnemy" , 0f , spwaninterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpanRandomEnemy()
    {
        int randomIndex = Random.Range(0, enemyPrefab.Length);
        int randomIndexPos = Random.Range(0, spawnpoint.Length);
        Instantiate(enemyPrefab[randomIndex] , spawnpoint[randomIndexPos].position , Quaternion.identity);
    }
}
