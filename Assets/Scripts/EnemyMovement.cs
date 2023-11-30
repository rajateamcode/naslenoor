using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    	rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	//rb.velocity = new Vector2(2f , 0);
    	
    		rb.velocity = new Vector2(0, -2f);
    		
    		if(transform.position.y < -1f){
    			RocketController.instance.score--;
    			Destroy(gameObject); 
    		}
    
    }
}