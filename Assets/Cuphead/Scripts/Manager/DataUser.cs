using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum EndGameState
{
    Win,
    Lose
}


public class DataUser : MonoBehaviour
{
    public int money = 0;
    public TextMeshProUGUI moneyText;
    private float remainingTime;
    public int time;
    public TextMeshProUGUI timeRemainText;
    public int star;
    //public bool allWavesCompleted;
    public LevelConfiguration levelConfiguration;

    public void AddMoney(int amount)
    {
        money += amount;
        Debug.Log("Money added: " + amount + ". Current money: " + money);
    }
    public void AddTimer(int amount)
    {
        remainingTime += amount;
    }
    void Start()
    {
        money = 0;
        remainingTime = time;
        StartCoroutine(CountdownTimer());
    }

    void Update()
    {
        timeRemainText.SetText("Time: " + Mathf.CeilToInt(remainingTime));
        moneyText.SetText("" + money);
    }
    public void CurrentStar()
    {
        if (remainingTime >= 50)
        {
            star = 3;
        }
        else if (remainingTime >= 30)
        {
            star = 2;
        }
        else if (remainingTime > 0)
        {
            star = 1;
        }
        else
        {
            star = 0;
        }
    }
    private IEnumerator CountdownTimer()
    {
        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(1f);
            remainingTime--;
        }
        GameOver(EndGameState.Lose);
    }

    public void GameOver(EndGameState endGameType)
    {
        CurrentStar();
        if (endGameType == EndGameState.Lose)
        {
            star = 0;
            money = 0;
        }

        if (endGameType == EndGameState.Win)
        {
            int levelCurrent = PlayerPrefs.GetInt("Current_Level");
            // Set win game
            PlayerPrefs.SetInt("Level_Win_" + levelCurrent, 1);
            // Level_Win_1
            // Level_Win_2

        }

        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.SetInt("Star", star);
        SceneManager.LoadScene("End");
    }
}
