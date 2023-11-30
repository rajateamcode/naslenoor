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
        StandardBannerScene.instance.Request();
    }

}
