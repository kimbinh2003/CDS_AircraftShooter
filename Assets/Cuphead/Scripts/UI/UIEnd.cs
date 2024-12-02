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
    public GameObject characterHolders;
    private void Start()
    {
        moneyText.SetText("" + PlayerPrefs.GetInt("Money"), 0);
        starText.SetText("" + PlayerPrefs.GetInt("Star"), 0);

        var currentCharacter = characterHolders.transform.GetChild(PlayerPrefs.GetInt("CharacterSelected"));
        currentCharacter.gameObject.SetActive(true);

    }
    public void OpenSettingUI()
    {
        uiSetting.SetActive(true);
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
