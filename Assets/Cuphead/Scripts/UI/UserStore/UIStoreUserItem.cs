using UnityEngine;

public class UIStoreUserItem : MonoBehaviour
{
    public int id;
    public UIStoreUser store;

    public GameObject useButton;
    public GameObject usedButton;
    public void Setup()
    {
        if (PlayerPrefs.HasKey("Character_" + id) || id == 0) // neu da mua
        {
            if (PlayerPrefs.GetInt("CharacterSelected", 0) == id)
            {
                usedButton.SetActive(true);
                useButton.SetActive(false);
            } 
            else
            {
                useButton.SetActive(true);
                usedButton.SetActive(false);
            }
        }
        else
        {
            // chua mua
            useButton.SetActive(false);
            usedButton.SetActive(false);
        }
    }

    public void UseOnClicked()
    {
        PlayerPrefs.SetInt("CharacterSelected", id);
        store.ShowUI();
    }
}