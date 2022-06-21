using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float scroll = 9.9f;
    [SerializeField] private float moveSpeed = 3.0f;
    [SerializeField] private Vector3 moveDirection = Vector3.left;

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        if(transform.position.x <= -scroll)
        {
            transform.position = target.position + Vector3.right * scroll;
        }
    }
}
