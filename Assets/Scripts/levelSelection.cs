using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelection : MonoBehaviour
{
	void Start()
	{
		StandardBannerScene.instance.Request();
	}

    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }

}
