using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class LevelConfiguration : MonoBehaviour
{
    public List<MapConfiguration> ListWave;
    public int currentWave = 0;
    public UIGameplay uiGameplay;
    public DataUser dataUser;

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
            dataUser.allWavesCompleted = true;  //finish all wave
            dataUser.CurrentStar();  
            Debug.Log("Stars for completing all waves: " + DataUser.star);
            return;
        }
        ListWave[currentWave].StartWave();
        uiGameplay.SetWave(currentWave + 1, ListWave.Count);
    }

    public void TimeIsUp()
    {
        if (currentWave < ListWave.Count)
        {
            Debug.Log("TIME'S UP! No stars awarded.");
            dataUser.allWavesCompleted = false;  //don't finish all wave
            dataUser.CurrentStar();  
        }
    }
}
