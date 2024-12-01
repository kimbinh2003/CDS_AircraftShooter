using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStore : MonoBehaviour
{
    public List<UIStoreItem> items;


    public void ShowUI()
    {
        gameObject.SetActive(true);
        foreach (var item in items)
        {
            item.Setup();
        }
    }

    public void CloseUI()
    {
        gameObject.SetActive(false);
    }
}
