using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevelButtonItem : MonoBehaviour
{
    public int level;
    public GameObject playGame;
    public GameObject winGame;
    public TextMeshProUGUI levelText;
    public void Setup()
    {
        levelText.SetText("" + level);
        if (PlayerPrefs.HasKey("Level_Win_" + level))
        {
            playGame.SetActive(false);
            winGame.SetActive(true);
        }
        else
        {
            playGame.SetActive(true);
            winGame.SetActive(false);
        }
    }
    public void PlayOnClicked()
    {
        PlayerPrefs.SetInt("Level_Unlock_" + level, 1);
        PlayerPrefs.SetInt("Current_Level", level);
        //Setup();

        SceneManager.LoadScene("Gameplay");
    }
    public void WinGame()
    {
        winGame.SetActive(true);
        playGame.SetActive(false);
    }
}
