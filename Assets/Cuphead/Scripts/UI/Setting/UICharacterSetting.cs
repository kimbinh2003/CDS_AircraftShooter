using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICharacterSetting : MonoBehaviour
{
    public List<UICharacterSettingItem> items;

    public void ShowUI()
    {
        gameObject.SetActive(true);
        foreach (var item in items)
        {
            item.Setup();
        }
    }
}
