using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Player
{
    class PlayerMelee : PlayerAttack
    {
        [SerializeField]
        private Collider2D swordCollider;
        protected override void AttackEnemy()
        {
            swordCollider.enabled = IsAttack ? true : false;
        }

    }
}
