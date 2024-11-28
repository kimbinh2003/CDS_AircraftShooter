using UnityEngine;
using TMPro;

public class UIGameplay : MonoBehaviour
{
    public TextMeshProUGUI waveText;
    public void SetWave(int waveCurrent, int waveMax)
    {
        if (waveCurrent < waveMax)
        {
            waveText.SetText("Wave: " + waveCurrent + "/" + waveMax);
        }
        else
        {
            waveText.SetText("Wave BOSS!!");
        }
    }
    public GameObject uiSettingGameplay;
    public void OpenUISettingGameplay()
    {
        uiSettingGameplay.SetActive(true);
    }
    public GameObject uiPauseSettings;
    public void OpenUIPauseSettings()
    {
        uiPauseSettings.SetActive(true);
    }
}