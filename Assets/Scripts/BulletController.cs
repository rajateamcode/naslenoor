using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{
    public float speed = 10f;
 
    
    void Update()
    {
        // Move the bullet upward
        //transform.Translate(Vector3.up * speed * Time.deltaTime);
        
            
            

                
                transform.position = Vector3.MoveTowards(transform.position, RocketController.instance.mouseWorldPosition, 10f);





                
        

            
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("detected");
        // Check if the bullet collided with an enemy
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the bullet
            RocketController.instance.score++;
        }
        if (other.CompareTag("Freind"))
        {
        	if(PlayerPrefs.GetInt("Vibrate") == 1)
	    		Handheld.Vibrate();
        	
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the bullet
            RocketController.instance.score--;
        }
    }
}
