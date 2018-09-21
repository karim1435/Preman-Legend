using Assets.Scripts.Characterrr;
using Assets.Scripts.Weapon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Characterrr.Helths
{
    public abstract class Health : AbstractBehavior
    {
        public delegate void Death();
        public event Death OnDeath;

        private Character character;
        protected float initialHealth;
        [SerializeField]
        protected float currentHealth;
        [SerializeField]
        private List<string> damageSources;

        protected bool die;
        protected bool attacked;

        [SerializeField]
        protected float knockBack;
        [SerializeField]
        protected float knockBackLength;
        [SerializeField]
        protected float knockBackCount;

        public bool knockFromRight;
        public bool Attacked { get { return attacked; } }
        public bool Die { get { return die; } }
        protected Rigidbody2D body2D ;
        protected virtual void Start()
        {
            body2D = GetComponent<Rigidbody2D>();
            character = GetComponent<Character>();
            initialHealth = character.Health;
            currentHealth = initialHealth;
        }
        public void SetAttacked()
        {
            attacked = false;
        }
        protected  void OnCharacterDeath()
        {
            if (OnDeath != null)
                OnDeath();
        }
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

            ShouldKnockBack();

            CheckIfZero();
        }
        private void ShouldKnockBack()
        {
            knockBackCount = knockBackLength;
        }
        private void CheckIfZero()
        {
            if (currentHealth <= 0)
            {
                die = true;
                OnCharacterDeath();
            }
        }
        private void Update()
        {
           KnockBack();
        }
        private void KnockBack()
        {
            if(knockBackCount>0)
            {
                body2D.AddForce(new Vector2(knockBack, 0));
                knockBackCount -= Time.deltaTime;
            }
        }
    }
}
