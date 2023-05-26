using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground_Type01 : MonoBehaviour
{
    [SerializeField]
    private Transform target;   //���� ���� �̾����� ���
    [SerializeField]
    private float scrollAmount; // �̾����� �� ��� ������ �Ÿ� 
    [SerializeField]
    private float moveSpeed;    // �̵� �ӵ� 
    [SerializeField]
    private Vector3 moveDirection;  // �̵� ����

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * 0.1f * Time.deltaTime;

        if (transform.position.x <= -scrollAmount)
        {
            transform.position = target.position - moveDirection * scrollAmount;
        }
    }
}
