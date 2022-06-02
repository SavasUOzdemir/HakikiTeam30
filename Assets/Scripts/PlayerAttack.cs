using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
   private Animator anim;
   private Movement playerMovement;
   [SerializeField] private float attackCooldown;
   [SerializeField] private Transform firePoint;
   [SerializeField] private GameObject[] fireballs;
   private float coolDownTimer = Mathf.Infinity;

   private void Awake() {
       anim = GetComponent<Animator>();
       playerMovement = GetComponent<Movement>();
   }

    private void Update() {
        if (Input.GetMouseButton(0) && coolDownTimer > attackCooldown && playerMovement.canAttack())
        {
            Attack();    
            coolDownTimer += Time.deltaTime;
        }
    }

    private void Attack()
    {
        coolDownTimer = 0;
        fireballs[FindFireball()].transform.position = firePoint.position;
        fireballs[FindFireball()].GetComponent<Projectile>().setDirection(Mathf.Sign(transform.localScale.x)); 
    }

    private int FindFireball()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }
}
