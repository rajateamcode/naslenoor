using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RocketController : MonoBehaviour
{
    public float speed = 5f;
    public float repeatRate = 0.2f;
    public GameObject bulletPrefab;
    public int score;
    public TMP_Text timetext;
    public float roundTime = 20f;
    bool endingRound = false;


    public static RocketController instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(roundTime > 0)
        {
            roundTime -= Time.deltaTime;
            if(roundTime <= 0 )
            {
                roundTime = 0f;
                endingRound = true;
            }
        }
        timetext.text = roundTime.ToString("0.0") + " s";
        float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(score);
        
    }

    void SpawnBullet()
    {
        // Instantiate a bullet at the rocket's position
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

    public void RightMovement()
    {
        if (transform.position.x < 1.73)
            transform.position += Vector3.right * speed * Time.deltaTime;
        SpawnBullet();
    }


    public void LeftMovement()
    {
        if (transform.position.x > -1.73)
            transform.position += Vector3.left * speed * Time.deltaTime;
        SpawnBullet();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("detected");
  
    }
}
    

