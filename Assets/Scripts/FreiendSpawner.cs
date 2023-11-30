using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreiendSpawner : MonoBehaviour
{
    public GameObject[] friendPrefab;
    public Transform[] friendspawnpoint;

    public float spwaninterval1 = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
    	//int randomIndexTime = Random.Range(spwaninterval1, spwaninterval2);
        InvokeRepeating("SpanRandomFreiend" , 0f , spwaninterval1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpanRandomFreiend()
    {
        int randomIndex = Random.Range(0, friendPrefab.Length);
        int randomIndexPos = Random.Range(0, friendspawnpoint.Length);
        Instantiate(friendPrefab[randomIndex] , friendspawnpoint[randomIndexPos].position , Quaternion.identity);
    }
}
