using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStoreUser : MonoBehaviour
{
    public List<UIStoreUserItem> items;
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
