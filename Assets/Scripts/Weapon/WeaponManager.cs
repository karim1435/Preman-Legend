using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Weapon
{
    public class WeaponManager:MonoBehaviour
    {
        [SerializeField]
        private int totalFire;

        public int TotalFire { get { return totalFire; } }

        public bool IsWeaponAvailable { get { return totalFire >=0; } }
        public void UseWeapon()
        {
            totalFire -= 1;
        }

       
    }
}
