using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Character.EnemyStates
{
    public class EnemyHealth:MonoBehaviour
    {
        private Enemy enemy;
        [SerializeField]
        private float health;
        private float initialHealth;
        public bool attacked { get; private set;}
        public bool die { get; private set; }
        void Start()
        {
            enemy = GetComponent<Enemy>();
            initialHealth = enemy.Health;
            health = initialHealth;

            enemy.OnTriggerEnter += OnTrigger;
        }
        void OnDisable()
        {
            enemy.OnTriggerEnter -= OnTrigger;
        }
        void OnTrigger(Collider2D other)
        {
            if (other.tag=="Sword")
                DamageHp();
        }
        private void DamageHp()
        {
            attacked = true;
            health -= 10;
            ChechIfZero();
        }
        public void SetAttacked()
        {
            attacked = false;
        }
        private void ChechIfZero()
        {
            if (health <= 0)
            {
                die = true;
            }
        }
    }
}
