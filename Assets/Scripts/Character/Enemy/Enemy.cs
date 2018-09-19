using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class Enemy : Character
    {
        public delegate void OnTrigger(Collider2D other);
        public event OnTrigger OnTriggerEnter;
        #region SerializeField
        [SerializeField]
        private float throwRange;
        [SerializeField]
        private float meeleRange;
        #endregion 

        public float MeeleRange { get {return meeleRange; } }
        public float ThrowRange { get { return throwRange; } }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (OnTriggerEnter != null)
                OnTriggerEnter(other);
        }
    }
}
