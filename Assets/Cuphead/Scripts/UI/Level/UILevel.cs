using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevel : MonoBehaviour
{
    public List<UILevelButtonItem> levelButtons;

    private void Start()
    {
        Show();
    }
    public void Show()
    {
        for (int i = 0; i < levelButtons.Count; i++)
        {
            levelButtons[i].Setup();
        }
    }
}
