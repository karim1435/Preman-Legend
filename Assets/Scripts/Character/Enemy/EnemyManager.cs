using Assets.Scripts.Characterrr.EnemyStates;
using Assets.Scripts.Player.EnemyStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Characterrr
{
    public class EnemyManager:MonoBehaviour
    {
        private Animator animator;
        private EnemyBehavior enemyBehavior;
        private EnemyHealth enemyHealth;
        void Start()
        { 
            enemyBehavior = GetComponent<EnemyBehavior>();
            animator = GetComponent<Animator>();
            enemyHealth = GetComponent<EnemyHealth>();
        }
        void Update()
        {
            if (enemyBehavior.Idle)
                ChangeAnimation(0);
            if (enemyBehavior.Petrolling)
                ChangeAnimation(1);
            if (enemyBehavior.Fighting)
                ChangeAnimation(2);
            if (enemyBehavior.Shoot)
                ChangeAnimation(3);
            if (enemyHealth.Attacked)
                ChangeAnimation(4);
            if (enemyHealth.Die)
                ChangeAnimation(5);
        }
        void ChangeAnimation(int value)
        {
            animator.SetInteger("playerAnimState", value);
        }
    }
}
