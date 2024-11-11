using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    private void Start()
    {
        SetupCharacterSelect();
    }
    public GameObject uiSetting;
    public void OpenSettingUI()
    {
        uiSetting.SetActive(true);
    }

    public UICharacterSelection uiSelection;
    public void SetupCharacterSelect()
    {
        uiSelection.SetUp();
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
    public void CloseStoreUserUI()
    {
        SetupCharacterSelect();
        uiStoreUser.CloseUI();
    }

}
