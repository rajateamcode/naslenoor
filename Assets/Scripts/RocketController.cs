using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class RocketController : MonoBehaviour
{
    public float speed = 5f;
    public float repeatRate = 0.2f;
    public GameObject bulletPrefab;
    public int score;
    public TMP_Text timetext;
    public TMP_Text Scoretext;
    public float roundTime = 20f;
    bool endingRound = false;
    public GameObject endlevel;


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
        StandardBannerScene.instance.Show();
    }

    // Update is called once per frame
    void Update()
    {
        if(roundTime > 0)
        {
            roundTime -= Time.deltaTime;
            if(roundTime <= 0 )
            {
            	GameOver();
                roundTime = 0f;
                endingRound = true;
            }
        }
        timetext.text = roundTime.ToString("0.0") + " s";
        Scoretext.text =  score.ToString();
        float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(score);
        
        //    ********************* move by finger *******************
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
        	Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        	targetPosition.z = 0;
        	
        	transform.position = Vector3.MoveTowards(transform.position , targetPosition , 5 * Time.deltaTime);

        }
        
        StartCoroutine("SpawnBullet");
        
    }

IEnumerator SpawnBullet()
    {
	while(true){
		Vector3 spawnPos = transform.position + new Vector3(0f , 2f , 0f);

		GameObject bullet = Instantiate(bulletPrefab,  spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(0.8f);
	}

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("detected");
  
    }
    
    
    void GameOver()
    {
    	StandardBannerScene.instance.Request();
    }
    
    
    public void GoToMainMenue()
	{
		StandardBannerScene.instance.Hide();
		SceneManager.LoadScene("first");
	}
}
    

