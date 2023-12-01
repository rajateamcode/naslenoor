using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	Rigidbody2D rb;
	public float speed;
	public ParticleSystem explossion;
    // Start is called before the first frame update
    void Start()
    {
    	rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	//rb.velocity = new Vector2(2f , 0);
    	
    		rb.velocity = new Vector2(0, -2f) * speed;
    		
    		if(transform.position.y < -1f){
    			if(PlayerPrefs.GetInt("sounds", 1) == 1)
    				this.gameObject.GetComponent<AudioSource>().Play();
    			
    			if(PlayerPrefs.GetInt("Vibrate" , 1) == 1)
        			Handheld.Vibrate();
    			Instantiate(explossion , transform.position , Quaternion.identity);
    			
    			RocketController.instance.score--;
    			Destroy(gameObject); 
    		}
    
    }
    
 
 
}
