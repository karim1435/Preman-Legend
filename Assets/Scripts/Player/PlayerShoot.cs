using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Player
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
            GameObject temp = (GameObject)Instantiate(knifePrefarb);
            temp.transform.position = knifePositon.position;
        }

    }
}
