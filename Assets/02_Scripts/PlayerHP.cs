using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] float maxHP = 10;
    float curHP;
    SpriteRenderer spriteRenderer;
    PlayerController playerController;
    ItemSpawner iS;

    public float MaxHP => maxHP;
    public float CurHP => curHP;

    private void Awake()
    {
        curHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
        iS = FindObjectOfType<ItemSpawner>();

    }
    private void Update()
    {
        if(curHP > maxHP)
        {
            curHP = MaxHP;
        }
    }
    public void takeDamage(float damage)
    {
        curHP -= damage;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if (curHP <= maxHP / 2)
        {
            iS.ItemSpawn();
        }

        if (curHP <= 0)
        {
            playerController.OnDie();
        }
    }
    public void getItem(float heal)
    {
        curHP += heal;
    }

    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }

}