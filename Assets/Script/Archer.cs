using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void ShootBtn()
    {
        animator.SetTrigger("Shoot_t");
        float tempHp = animator.GetFloat("Hp_f");
        animator.SetFloat("Hp_f", tempHp - 10);
    }

    public void DieBtn()
    {
        float tempHp = animator.GetFloat("Hp_f");
        if (tempHp > 0)
        {
            animator.SetTrigger("Die_t");
            animator.SetFloat("Hp_f", 0);
        }
    }

    public void OnDieEvent()
    {
        Debug.Log("onDie");
    }
}
