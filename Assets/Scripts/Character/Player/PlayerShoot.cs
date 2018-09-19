using Assets.Scripts.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Character
{

    public class PlayerShoot:PlayerAttack
    {
        [SerializeField]
        private GameObject knifePrefarb;
        [SerializeField]
        private Transform knifePositon;
        protected override void AttackEnemy()
        {        
        }
        public void Shoot()
        {
            if(player.Dir==Direction.Right)
                InstantiateFire(Quaternion.Euler(0, 0, -90), Vector2.right);
            else
                InstantiateFire(Quaternion.Euler(0, 0, 90), Vector2.left);    
        }
        public void InstantiateFire(Quaternion rotation,Vector2 dir)
        {
            GameObject gun = Instantiate(knifePrefarb, knifePositon.position, rotation) as GameObject;
            gun.GetComponent<IShoot>().InitializeDirection(dir);
        }

    }
}
