using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvBar : MonoBehaviour
{
    public Image lvBar;

    public void SetHpPercent(float percent)
    {
        lvBar.fillAmount = percent;
    }
}