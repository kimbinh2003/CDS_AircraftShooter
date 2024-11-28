using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private MapConfiguration spawnFromMap;

    public void SetMapConfiguration(MapConfiguration mapConfiguration)
    {
        this.spawnFromMap = mapConfiguration;
    }

    private void OnDestroy()
    {
        spawnFromMap.KillEnemy();
    }
}