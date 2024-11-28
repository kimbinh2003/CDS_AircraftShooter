using UnityEngine;
using UnityEngine.UI;

public class UILoading : MonoBehaviour
{
    public Image hpBar;


    private float currentProgress = 0;
    public float speed;
    private void Update()
    {
        currentProgress += Time.deltaTime * speed;
        hpBar.fillAmount = currentProgress;
    }
}