using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Threading;
public class DataUser : MonoBehaviour
{
    public static int money = 0;
    public TextMeshProUGUI moneyText;
    private float remainingTime;
    public static int time;
    public TextMeshProUGUI timeRemainText;
    public static int star;
    public bool allWavesCompleted;

    public static void AddMoney(int amount)
    {
        money += amount;
        Debug.Log("Money added: " + amount + ". Current money: " + money);
    }
    public void AddTimer(int amount)
    {
        remainingTime += amount;
    }
    public int TimePlay;
    void Start() 
    {
        money = 0;
        remainingTime = TimePlay; 
        StartCoroutine(CountdownTimer());
    }

    void Update()
    {
        timeRemainText.SetText("Time: " + Mathf.CeilToInt(remainingTime));
        moneyText.SetText("" + money);
    }
    public void CurrentStar()
    {
        if (allWavesCompleted) 
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
        GameOver();
    }

    public void GameOver()
    {
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.SetInt("Star", star);
        Time.timeScale = 0;
        SceneManager.LoadScene("End");
    }

}
