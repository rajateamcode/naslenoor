using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform[] spawnpoint;

    public float spwaninterval = 2f;
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
        Instantiate(enemyPrefab[randomIndex] , spawnpoint[randomIndex].position , Quaternion.identity);
    }
}
