using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level1 : MonoBehaviour
{
	int levelScore;
	float levelTime;
	public GameObject gameOverPanel;
	public GameObject winPanel;
	//public GameObject Rocket;
	public GameObject timeText;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gameOverPanel.SetActive(false);
        StandardBannerScene.instance.Show();
    }

    // Update is called once per frame
    void Update()
    {
        levelScore = RocketController.instance.score;
        levelTime = RocketController.instance.roundTime;
        if(levelTime <= 0 && levelScore <= 0)
        	GameOver();
        else if(levelTime <= 0  && levelScore > 0 )
        	Win();
        
        
    }
    
    
    void GameOver()
    {
        
        gameOverPanel.SetActive(true);
    	//Rocket.SetActive(false);
    	timeText.SetActive(false);
    	StandardBannerScene.instance.Request();
    	Time.timeScale = 0f;
        
    }
    
    void Win()
    {
        
        winPanel.SetActive(true);
    	//Rocket.SetActive(false);
    	timeText.SetActive(false);
    	Time.timeScale = 0f;
    }
    
    public void playAgain()
    {
    	SceneManager.LoadScene("level1");
    }
    

    
    public void Home()
    {
    	SceneManager.LoadScene("first");
    }
    
    public void NextLevel()
    {
    	SceneManager.LoadScene("level2");
    }
}
