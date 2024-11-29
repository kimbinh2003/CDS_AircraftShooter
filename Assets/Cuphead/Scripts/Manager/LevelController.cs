using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    void Start()
    {
        var levels = GameObject.Find("Levels");
        var currentLevel = levels.GetComponent<Transform>().GetChild(PlayerPrefs.GetInt("Current_Level") - 1);
        currentLevel.gameObject.SetActive(true);
    }
}
