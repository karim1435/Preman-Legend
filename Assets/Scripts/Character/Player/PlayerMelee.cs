using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Character
{
    public class PlayerMelee : PlayerAttack
    {
       
        protected override void ReadyToAttack()
        {
            AttackEnemy();
        }
    }
}
