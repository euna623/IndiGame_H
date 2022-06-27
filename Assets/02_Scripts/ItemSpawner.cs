using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] StageData stageData;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] float spawnTime;

    PlayerHP HP;

    private void Awake()
    {
        HP = GameObject.Find("Player").GetComponent<PlayerHP>();
    }

    public void ItemSpawn()
    {
        StartCoroutine(SpawnEnemy());
    }
    public void ItemSpawnStop()
    {
        StopAllCoroutines();
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float positionY2 = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y);
            Instantiate(itemPrefab, new Vector3(stageData.LimitMax.x + 1.0f, positionY2, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
