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
	public GameObject Rocket;
	public GameObject timeText;
    // Start is called before the first frame update
    void Start()
    {
    	gameOverPanel.SetActive(false);
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
    	Rocket.SetActive(false);
    	timeText.SetActive(false);
    }
    
    void Win()
    {
    	winPanel.SetActive(true);
    	Rocket.SetActive(false);
    	timeText.SetActive(false);
    }
    
    public void playAgain()
    {
    	SceneManager.LoadScene("level1");
    }
    
    public void levelSelection()
    {
    	SceneManager.LoadScene("levelSelection");
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
