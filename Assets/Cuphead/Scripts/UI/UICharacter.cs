using System.Collections.Generic;
using UnityEngine;

public class UICharacter : MonoBehaviour
{
    public List<UICharacterItem> items;

    public void ShowUI()
    {
        gameObject.SetActive(true);
        foreach (var item in items)
        {
            item.Setup();
        }
    }  
}
