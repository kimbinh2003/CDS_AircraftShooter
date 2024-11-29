using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILvBar : MonoBehaviour
{
    public Image lvBar;


    private float currentProgress = 0;
    public float speed;
    private void Update()
    {
        currentProgress += Time.deltaTime * speed;
        lvBar.fillAmount = currentProgress;
    }
}
