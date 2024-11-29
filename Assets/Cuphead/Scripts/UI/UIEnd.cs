using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEnd : MonoBehaviour
{
    public GameObject uiSetting;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI starText;
    private void Start()
    {
        moneyText.SetText("" + PlayerPrefs.GetInt("Money"));
        starText.SetText("" + PlayerPrefs.GetInt("Star"));
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
    public void NextGame()
    {
        SceneManager.LoadScene("Level");
    }
}
