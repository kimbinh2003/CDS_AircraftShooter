using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevelButtonItem : MonoBehaviour
{
    public int level;
    public GameObject playGame;
    public GameObject lock_PlayGame;
    public GameObject winGame;
    public TextMeshProUGUI levelText;
    public void Setup()
    {
        levelText.SetText("" + level);
        bool isLevelWon = PlayerPrefs.HasKey("Level_Win_" + level);

        // Lấy level gần nhất đã thắng
        int lastLevelWon = 0;
        for (int i = 1; i <= level; i++)
        {
            if (PlayerPrefs.HasKey("Level_Win_" + i))
            {
                lastLevelWon = i;
            }
        }
        // Trường hợp 1: Người chơi có thể chơi level hiện tại
        if (level == lastLevelWon + 1)
        {
            playGame.SetActive(true);
            lock_PlayGame.SetActive(false);
            winGame.SetActive(false);
        }
        // Trường hợp 2: Người chơi đã thắng level này
        else if (isLevelWon)
        {
            playGame.SetActive(false);
            lock_PlayGame.SetActive(false);
            winGame.SetActive(true);
        }
        // Trường hợp 3: Level bị khóa vì không nằm liền kề level vừa thắng
        else
        {
            playGame.SetActive(false);
            lock_PlayGame.SetActive(true);
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
        SceneManager.LoadScene("Gameplay");
    }

}
