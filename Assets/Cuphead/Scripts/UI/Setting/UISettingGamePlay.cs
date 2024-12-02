using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISettingGamePlay : MonoBehaviour
{
    public void CloseUI()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public GameObject musicModeOn;
    public GameObject musicModeOff;
    public GameObject soundModeOn;
    public GameObject soundModeOff;
    public void Start()
    {
        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            musicModeOn.SetActive(true);
            musicModeOff.SetActive(false);
        }
        else
        {
            musicModeOn.SetActive(false);
            musicModeOff.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            soundModeOn.SetActive(true);
            soundModeOff.SetActive(false);
        }
        else
        {
            soundModeOn.SetActive(false);
            soundModeOff.SetActive(true);
        }
    }
    public void musicOn()
    {
        FindObjectOfType<AudioManager>().SetMusic(0);
        PlayerPrefs.SetInt("Music", 0);
        musicModeOn.SetActive(false);
        musicModeOff.SetActive(true);
    }
    public void musicOff()
    {
        FindObjectOfType<AudioManager>().SetMusic(1);
        PlayerPrefs.SetInt("Music", 1);
        musicModeOn.SetActive(true);
        musicModeOff.SetActive(false);
    }
    public void soundOn()
    {
        PlayerPrefs.SetInt("Sound", 0);
        soundModeOn.SetActive(false);
        soundModeOff.SetActive(true);
    }
    public void soundOff()
    {
        PlayerPrefs.SetInt("Sound", 1);
        soundModeOn.SetActive(true);
        soundModeOff.SetActive(false);
    }
    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }
   
}
