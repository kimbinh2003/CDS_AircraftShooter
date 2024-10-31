using UnityEngine;

public class UIStoreUserItem : MonoBehaviour
{
    public int id;
    public UIStoreUser store;
    public UICharacter character;

    public GameObject useButton;
    public GameObject usedButton;
    public void Setup()
    {
        if (PlayerPrefs.HasKey("Character_" + id)) // neu da mua
        {
            if (PlayerPrefs.GetInt("CharacterSelected") == id)
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