using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject attackPrefab;
    [SerializeField] private float attackRate = 0.1f;

    public void StartFiring()
    {
        StartCoroutine("TryAttack");
    }

    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }

    IEnumerator TryAttack()
    {
        while (true)
        {
            Instantiate(attackPrefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(attackRate);
        }
    }
}
