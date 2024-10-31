using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIStoreItem : MonoBehaviour
{
    public int id;
    public int price; // gia tien
    public TextMeshProUGUI priceText;

    public GameObject canBuyObject;
    public GameObject boughtObject;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Setup()
    {
        priceText.text = price.ToString();
        if (PlayerPrefs.HasKey("Character_" + id))
        {
            // da mua
            canBuyObject.SetActive(false);
            boughtObject.SetActive(true);
        }
        else
        {
            // chua mua
            canBuyObject.SetActive(true);
            boughtObject.SetActive(false);
        }
    }

    public void BuyOnClicked()
    {
        PlayerPrefs.SetInt("Character_" + id, 1);
        Setup();
    }
}
