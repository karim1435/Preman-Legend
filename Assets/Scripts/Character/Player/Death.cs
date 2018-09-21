using Assets.Scripts.Characterrr.Helths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Characterrr.Playersd
{
    public abstract class Death:AbstractBehavior
    {
        protected Health health;

        void Start()
        {
            health = GetComponent<Health>();

            health.OnDeath += Dead;
        }
        void OnDisable()
        {
            health.OnDeath -= Dead;
        }
        protected abstract void Dead();
    }
}
