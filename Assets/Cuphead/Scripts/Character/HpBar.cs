using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Image hpBar;

    public void SetHpPercent(float percent)
    {
        hpBar.fillAmount = percent;
    }
}
