using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyphoonSpawner : MonoBehaviour
{
    [SerializeField] private StageData stageData;
    [SerializeField] private GameObject typhoonLinePrefab;
    [SerializeField] private GameObject typhoonPrefab;
    [SerializeField] private float minSpawnTime = 1.0f;
    [SerializeField] private float maxSpawnTime = 4.0f;

    private void Awake()
    {
        StartCoroutine("SpawnTyphoon");
    }

    private IEnumerator SpawnTyphoon()
    {
        while (true)
        {
            float positionY = Random.Range(stageData.LimitMin.y, stageData.LimitMax.y);
            GameObject alertLineClone = Instantiate(typhoonLinePrefab, new Vector3(0, positionY, 0), Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            Destroy(alertLineClone);
            Vector3 typhoonPosition = new Vector3(stageData.LimitMax.x + 1.0f, positionY, 0);
            Instantiate(typhoonPrefab, typhoonPosition, Quaternion.identity);
            float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
