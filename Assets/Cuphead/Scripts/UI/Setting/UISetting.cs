using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UISetting : MonoBehaviour
{
    public void CloseUI()
    {
        gameObject.SetActive(false);
    }
    public GameObject musicOnGameObject;
    public GameObject musicOffGameObject;
    public GameObject soundOnGameObject;
    public GameObject soundOffGameObject;
    public TextMeshProUGUI Total_Money;
    public TextMeshProUGUI Total_Star;
    public GameObject[] characters;


    private void Start()
    {
        currencyManagement();
        starManagement();
    }
    private void OnEnable()
    {

        setCharacter();

        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            musicOffGameObject.SetActive(false);
            musicOnGameObject.SetActive(true);
        }
        else
        {
            musicOffGameObject.SetActive(true);
            musicOnGameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            soundOffGameObject.SetActive(false);
            soundOnGameObject.SetActive(true);
        }
        else
        {
            soundOffGameObject.SetActive(true);
            soundOnGameObject.SetActive(false);
        }
    }

    private void setCharacter()
    {
        int characterSelected = PlayerPrefs.GetInt("CharacterSelected");
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == characterSelected)
            {
                characters[i].SetActive(true);
            }
            else
            {
                characters[i].SetActive(false);
            }
        }
    }

    public void musicON()
    {
        PlayerPrefs.SetInt("Music", 0);
        musicOffGameObject.SetActive(true);
        musicOnGameObject.SetActive(false);
    }
    public void musicOFF()
    {
        PlayerPrefs.SetInt("Music", 1);
        musicOffGameObject.SetActive(false);
        musicOnGameObject.SetActive(true);
    }
    public void soundON()
    {
        PlayerPrefs.SetInt("Sound", 0);
        soundOffGameObject.SetActive(true);
        soundOnGameObject.SetActive(false);
    }
    public void soundOFF()
    {
        PlayerPrefs.SetInt("Sound", 1);
        soundOffGameObject.SetActive(false);
        soundOnGameObject.SetActive(true);
    }  
     
    public void currencyManagement()
    {
        int TotalMoney = PlayerPrefs.GetInt("TotalMoney", 0);
        int CurrentMoney = PlayerPrefs.GetInt("Money");

        TotalMoney += CurrentMoney;
        PlayerPrefs.SetInt("TotalMoney", TotalMoney);
        Total_Money.SetText("" + TotalMoney);
    }

    public void starManagement()
    {
        int TotalStar = PlayerPrefs.GetInt("TotalStar", 0);
        int CurrentStar = PlayerPrefs.GetInt("Star");

        TotalStar += CurrentStar;
        PlayerPrefs.SetInt("TotalStar", TotalStar);
        Total_Star.SetText("" + TotalStar);
    }

    
}
