using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPauseSetting : MonoBehaviour
{
    public void CloseUI()
    {
        gameObject.SetActive(false);
    }
    public void ReSume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void Restart()
    {
        
    }
    public void EndGame()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        SceneManager.LoadScene("End");
    }
    
}
