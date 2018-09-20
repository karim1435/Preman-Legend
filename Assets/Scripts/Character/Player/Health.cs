using Assets.Scripts.Weapon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character.Helths
{
    public abstract class Health:MonoBehaviour
    {
        private Character character;
        protected float initialHealth;
        [SerializeField]
        protected float currentHealth;
        [SerializeField]
        private List<string> damageSources;

        protected bool die;
        protected bool attacked;

        public bool Attacked { get { return attacked; } }
        public bool Die { get { return die; } }
        protected virtual void Start()
        {
            character = GetComponent<Character>();
            initialHealth = character.Health;
            currentHealth = initialHealth;
        }
        public void SetAttacked()
        {
            attacked = false;
        }
        protected abstract void Death();
        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (damageSources.Contains(other.tag))
            {
                float attackPower=other.GetComponent<IWeapon>().AttackPower;
                TakeDamage(attackPower);
            }
        }
        protected virtual void TakeDamage(float attackPower)
        {
            attacked = true;
            currentHealth -= attackPower;
            CheckIfZero();
        }
        protected void CheckIfZero()
        {
            if (currentHealth <= 0)
                die = true;
        }
    }
}
