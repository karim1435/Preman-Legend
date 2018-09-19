using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public abstract class PlayerAttack:AbstractBehavior
    { 
        private float attackPower;
        private bool isAttack;
        protected Player player;
        public bool IsAttack { get { return isAttack; }set { isAttack = value; } }

        void Start()
        {
            player = GetComponent<Player>();
            attackPower = player.AttackPower;
        }
        void Update()
        {
            AttackEnemy();
            DisableScript();
            isAttack = CanAttack();
        }
        private void DisableScript()
        {
            if (isAttack) ToogleScript(false);
            else ToogleScript(true);
        }

        protected bool CanAttack()
        {
            var attack = inputState.GetButtonValue(inputButtons[0]);
            var holdTime = inputState.GetButtonHoldTime(inputButtons[0]);
            return attack && holdTime < .1f;
        }
        protected abstract void AttackEnemy();

    }
}
