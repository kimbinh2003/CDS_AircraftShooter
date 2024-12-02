using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    void Start()
    {
        var currentLevel = gameObject.transform.GetChild(PlayerPrefs.GetInt("Current_Level") - 1);
        currentLevel.gameObject.SetActive(true);
    }
}
