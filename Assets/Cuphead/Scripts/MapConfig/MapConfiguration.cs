using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 1. Game có bao nhiêu đợt quái (wave)
 * 2. Mỗi wave có bao nhiêu quái
 * 3. Quái sẽ xuất hiện tại thời điểm nào?
 *      - Quái đó là gì? => Prefab enemy
 *      - Thời gian xuất hiện? => float timeSpawn;
 * ***/

[System.Serializable] 
public class Wave
{
    public List<EnemyInWave> Enemies;
}

[System.Serializable]
public class EnemyInWave
{
    public GameObject enemyPrefab;
    public float timeSpawn; // thời gian xuất hiện tính từ lúc bắt đầu game
}


public class MapConfiguration : MonoBehaviour
{
    public Wave wave1;
    public List<Transform> spawnPoints;


    private void Start()
    {
        LevelSpawnEnemy();
    }

    private void LevelSpawnEnemy()
    {
        for (int i = 0; i < wave1.Enemies.Count; i++)
        {
            var enemyReadySpawnInfo = wave1.Enemies[i];
            StartCoroutine(SpawnEnemy(enemyReadySpawnInfo));
        }
    }

    IEnumerator SpawnEnemy(EnemyInWave enemyData)
    {
        yield return new WaitForSeconds(enemyData.timeSpawn);
        Debug.Log("Start spawn enemy: " + enemyData.enemyPrefab.name);

        var prefab = enemyData.enemyPrefab;
        var randomPoints = spawnPoints[Random.Range(0, spawnPoints.Count)];

        var enemy = Instantiate(prefab, randomPoints.position, prefab.transform.rotation);
        if (enemy.GetComponent<EnemyAutoMoveToTargetPos>() != null)
        {
            var autoMove = enemy.GetComponent<EnemyAutoMoveToTargetPos>();
            autoMove.SetPosition(randomPoints);
        }
    }
}