using Assets.Scripts.Character.Helths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
namespace Assets.Scripts.Character.Playerss
{
    public class PlayerHealth : Health
    {
        public void Damage(Collider2D other)
        {
            OnTriggerEnter2D(other);
        }
        protected override void Death()
        {
            //Destroy(gameObject);
        }
    }
}
