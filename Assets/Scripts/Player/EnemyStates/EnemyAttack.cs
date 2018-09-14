using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.EnemyStates
{
    public class EnemyAttack:MonoBehaviour
    {
        private Enemy enemy;
        private float meleeRange;
        private float throwRange;
        private GameObject target;
        private EnemyRange enemyRange;
        public GameObject Target { get { return target; } }
        
        void Start()
        {
            enemy = GetComponent<Enemy>();
            meleeRange = enemy.MeeleRange;
            throwRange = enemy.ThrowRange;

            enemyRange = FindObjectOfType<EnemyRange>();
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
                    return GetDistance(gameObject, target) <= throwRange;

                return false;
            }
        }
        public bool InMeeleRange
        {
            get
            {
                if (target != null)
                    return GetDistance(gameObject, target) <= meleeRange;

                return false;
            }
        }
        private float GetDistance(GameObject from, GameObject to)
        {
            return Vector2.Distance(from.transform.position, to.transform.position);
        }
        private void TargetAttack(GameObject other)
        {
            target = other;
        }
    }
}
