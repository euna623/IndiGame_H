using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private StageData stageData;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnTime;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float positionY = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y);
            Instantiate(enemyPrefab, new Vector3(stageData.LimitMax.x + 1.0f, positionY, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
