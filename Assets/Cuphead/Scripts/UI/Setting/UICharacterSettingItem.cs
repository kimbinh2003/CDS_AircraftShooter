using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICharacterSettingItem : MonoBehaviour
{
    public GameObject characterImage;  
    public int id;

    public void Setup()
    {
        if (PlayerPrefs.GetInt("CharacterSelected", 0) == id)
        {
            characterImage.SetActive(true);
        }
        else
        {           
            characterImage.SetActive(false);
        }
    }
}
