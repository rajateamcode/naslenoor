using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{
    public float speed = 0.05f;
    public Vector3 direction;
    
    
    void Start()
    {
    	//TargetPosition = transform.position;
    	direction.Normalize();
    }
    
    void Update()
    {

       transform.Translate(Vector3.up * speed * Time.deltaTime);

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
            if(PlayerPrefs.GetInt("highScore") < RocketController.instance.score) 
            	PlayerPrefs.SetInt("highScore" , RocketController.instance.score);
        }
        if (other.CompareTag("Freind"))
        {
        	if(PlayerPrefs.GetInt("Vibrate" , 1) == 1)
        		Handheld.Vibrate();
        	
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the bullet
            RocketController.instance.score--;
        }
    }
    
    
    public void SetTargetPosition(Vector3 target)
    {
    	direction = target.normalized;
    }
}
