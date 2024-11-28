using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConfiguration : MonoBehaviour
{
    public List<MapConfiguration> ListWave;
    public int currentWave = 0;
    public UIGameplay uiGameplay;

    private void Start()
    {
        foreach (var wave in ListWave) 
        {
            wave.SetLevelConfiguration(this);
        }
        ListWave[currentWave].StartWave();
        uiGameplay.SetWave(currentWave + 1, ListWave.Count);
    }

    public void NextWave()
    {
        currentWave++;
        if (currentWave >= ListWave.Count)
        {
            // WIn
            Debug.Log("WIN GAME");
            return;
        }
        ListWave[currentWave].StartWave();
        uiGameplay.SetWave(currentWave + 1, ListWave.Count);
    }
}
