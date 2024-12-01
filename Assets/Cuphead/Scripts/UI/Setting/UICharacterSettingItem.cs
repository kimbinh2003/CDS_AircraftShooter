using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICharacterSettingItem : MonoBehaviour
{
    public GameObject characterSettingImage;  
    public int id;

    public void Setup()
    {
        if (PlayerPrefs.GetInt("CharacterSelected", 0) == id)
        {
            characterSettingImage.SetActive(true);
        }
        else
        {
            
            characterSettingImage.SetActive(false);
        }
    }
}
