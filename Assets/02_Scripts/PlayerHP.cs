using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float maxHP = 10;
    private float curHP;
    private SpriteRenderer spriteRenderer;

    public float MaxHP => maxHP;
    public float CurHP => curHP;

    private void Awake()
    {
        curHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void takeDamage(float damage)
    {
        curHP -= damage;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if(curHP <= 0)
        {
            Debug.Log("Player HP : 0.. Die");
        }
    }

    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }

}