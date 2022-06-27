using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    PlayerController playerController;
    PlayerHP playerHP;
    ItemSpawner IS;
    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        playerHP = GameObject.Find("Player").GetComponent<PlayerHP>();
        IS = FindObjectOfType<ItemSpawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(playerHP.CurHP >= playerHP.MaxHP / 2)
            {
                IS.ItemSpawnStop();
            }
            playerHP.getItem(5);
            OnDie();
        }
    }

    public void OnDie()
    {
        Destroy(gameObject);
    }
}
