using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEnd : MonoBehaviour
{
    public GameObject uiSetting;
    private void Start()
    {
        
    }
    public void OpenSettingUI()
    {
        uiSetting.SetActive(true);
    }

    public void PlayGameAgain()
    {
        
    }
    
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
