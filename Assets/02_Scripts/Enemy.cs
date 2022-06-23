using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int damage = 1;
    [SerializeField] int scorePoint = 1;
    PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().takeDamage(damage);
            OnDie();
        }
    }

    public void OnDie()
    {
        playerController.Score += scorePoint;
        Destroy(gameObject);
    }
}
