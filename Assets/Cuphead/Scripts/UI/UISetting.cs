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
    
    private void Start()
    {

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
}
