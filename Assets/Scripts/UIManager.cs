using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject settingCanvas;
    [SerializeField] GameObject aboutUsCanvas;
    private void Start()
    {
        settingCanvas.SetActive(false);
        aboutUsCanvas.SetActive(false);
    }
    public void Play()
    {
        
    }

    public void Shop()
    {
        SceneManager.LoadScene("shop");
    }

    public void Setting()
    {
        settingCanvas.SetActive(true);
    }

    public void AboutUs()
    {
        aboutUsCanvas.SetActive(true);
    }

    public void Back()
    {
        Start();
    }
}
