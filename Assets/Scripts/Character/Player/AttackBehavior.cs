using Assets.Scripts.Weapon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character.Attack
{
    public abstract class AttackBehavior:AbstractBehavior
    {
        [SerializeField]
        private GameObject knifePrefarb;
        [SerializeField]
        private Transform knifePositon;
        [SerializeField]
        private List<string> damageSource;

        [SerializeField]
        protected Collider2D swordCollider;

        protected float attackPower;
        protected float shootDamage;
        protected float meleeAttack;
        protected float throwAttack;

        protected bool isAttack;
        protected Character character;
        public bool IsAttack { get { return isAttack; } set { isAttack = value; } }
        protected virtual void Start()
        {
            character = GetComponent<Character>();
            attackPower = character.AttackPower;
            shootDamage = character.ShootDamage;
            throwAttack = character.ThrowRange;
            meleeAttack = character.MeeleRange;
        }

        public void Shoot()
        {
            if (character.Dir == Direction.Right)
                InstantiateFire(Quaternion.Euler(0, 0, -90), Vector2.right);
            else
                InstantiateFire(Quaternion.Euler(0, 0, 90), Vector2.left);
        }
        private void InstantiateFire(Quaternion rotation, Vector2 dir)
        {
            GameObject gun = Instantiate(knifePrefarb, knifePositon.position, rotation) as GameObject;
            gun.GetComponent<IShoot>().InitializeDirection(dir);
        }
        protected void AttackEnemy()
        {
            swordCollider.enabled = IsAttack ? true : false;
        }
      
    }
}
