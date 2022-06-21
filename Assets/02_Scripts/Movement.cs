using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 0.0f;
    [SerializeField] private Vector3 moveDir = Vector3.zero;

    private void Update()
    {
        transform.position += moveDir * speed * Time.deltaTime;
    }

    public void MoveTo(Vector3 dir)
    {
        moveDir = dir;
    }
}
