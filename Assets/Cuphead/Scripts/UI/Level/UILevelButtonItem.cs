using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevelButtonItem : MonoBehaviour
{
    public int level;
    public GameObject playGame;
    public GameObject winGame;

    public void Setup()
    {
        if (PlayerPrefs.HasKey("Level_Unlock_" + level))
        {
            playGame.SetActive(true);
            winGame.SetActive(false);
            SceneManager.LoadScene("GamePlay");
        }
        else
        {
            playGame.SetActive(false);
            winGame.SetActive(true);
        }
    }
    public void PlayOnClicked()
    {
        PlayerPrefs.SetInt("Level_Unlock_" + level, 1);
        PlayerPrefs.SetInt("Current_Level", level);

        Setup();
    }
}
