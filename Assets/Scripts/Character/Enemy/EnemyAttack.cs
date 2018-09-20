using Assets.Scripts.Character.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character.EnemyStates
{
    public class EnemyAttack:AttackBehavior
    {
        private Enemy enemy;
        private GameObject target;
        private EnemyRange enemyRange;
        public GameObject Target { get { return target; }set { target = value; } }
        public bool attacking { get { return IsAttack; } set { IsAttack = value; } }
        protected override void Start()
        {
            base.Start();
            enemyRange = GetComponent<EnemyRange>();
            enemyRange.InRange += TargetAttack;
        }

        void OnDisable()
        {
            enemyRange.InRange -= TargetAttack;
        }
        public bool InThrowRange
        {
            get
            {
                if (target != null)
                    return GetDistance(gameObject, target) <= throwAttack;

                return false;
            }
        }
        public bool InMeeleRange
        {
            get
            {
                if (target != null)
                    return GetDistance(gameObject, target) <= meleeAttack;

                return false;
            }
        }
        private float GetDistance(GameObject from, GameObject to)
        {
            return Vector2.Distance(from.transform.position, to.transform.position);
        }
        void Update()
        {
            AttackEnemy();
        }
        private void TargetAttack(GameObject other)
        {
            target = other;
        }
        public void Attacking(int value)
        {
            IsAttack=value==1?true:false;           
        }
    }
}
