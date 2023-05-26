using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground_Type01 : MonoBehaviour
{
    [SerializeField]
    private Transform target;   //현재 배경과 이어지는 배경
    [SerializeField]
    private float scrollAmount; // 이어지는 두 배경 사이의 거리 
    [SerializeField]
    private float moveSpeed;    // 이동 속도 
    [SerializeField]
    private Vector3 moveDirection;  // 이동 방향

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * 0.1f * Time.deltaTime;

        if (transform.position.x <= -scrollAmount)
        {
            transform.position = target.position - moveDirection * scrollAmount;
        }
    }
}
