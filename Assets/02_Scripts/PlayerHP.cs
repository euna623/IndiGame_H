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

    public float MaxHP => maxHP;
    public float CurHP => curHP;

    private void Awake()
    {
        curHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
    }

    public void takeDamage(float damage)
    {
        curHP -= damage;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if(curHP <= 0)
        {
            playerController.OnDie();
        }
    }

    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }

}