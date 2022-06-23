using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] StageData stageData;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject enemyPrefab_2;
    [SerializeField] float spawnTime;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float positionY = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y);
            Instantiate(enemyPrefab, new Vector3(stageData.LimitMax.x + 1.0f, positionY, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
