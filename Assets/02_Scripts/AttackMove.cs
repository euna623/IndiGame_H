using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMove : MonoBehaviour
{
    [SerializeField] private float attackSpeed = 0.0f;
    [SerializeField] private Vector3 moveDir = Vector3.zero;

    private void Update()
    {
        transform.position += moveDir * attackSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 dir)
    {
        moveDir = dir;
    }
}
