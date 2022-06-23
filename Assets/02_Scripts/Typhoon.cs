using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Typhoon : MonoBehaviour
{
    [SerializeField] int damage = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().takeDamage(damage);
            Destroy(gameObject);
        }
    }
}
