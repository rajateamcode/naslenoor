using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelection : MonoBehaviour
{
	void Start()
	{
		
	}

    public void level1()
    {
        SceneManager.LoadScene("Level1");
        //StandardBannerScene.instance.Request();
    }
    
    public void level2()
    {
        SceneManager.LoadScene("Level2");
        //StandardBannerScene.instance.Request();
    }
    

    public void home()
    {
        SceneManager.LoadScene("first");
    }

}
