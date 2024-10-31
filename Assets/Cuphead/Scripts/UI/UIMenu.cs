using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    public GameObject uiSetting;
    public void OpenSettingUI()
    {
        uiSetting.SetActive(true);
    }

    public UIStore uiStore;
    public void OpenStoreUI()
    {
        uiStore.ShowUI();
    }
    public UIStoreUser uiStoreUser;
    public void OpenStoreUserUI()
    {
        uiStoreUser.ShowUI();
    }

}
