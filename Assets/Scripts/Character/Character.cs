using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public abstract class Character:MonoBehaviour
    {
        #region SerializeField
        [SerializeField]
        private float moveSpeed;
        [SerializeField]
        private float attackPower;
        [SerializeField]
        private float shootDamage;
        [SerializeField]
        private float health;
        #endregion
        #region SerializeField
        [SerializeField]
        private float throwRange;
        [SerializeField]
        private float meeleRange;
        #endregion 

        public float MeeleRange { get { return meeleRange; } }
        public float ThrowRange { get { return throwRange; } }
        private Direction direction = Direction.Right;
        public float AttackPower { get { return attackPower; } }
        public float ShootDamage { get { return shootDamage; } }
        public float MoveSpeed { get { return moveSpeed; } }
        public Direction Dir { get { return direction; } set { direction = value; } }
        public float Health { get { return health; }  }
        public virtual void ChangeDirection()
        {   
            transform.localScale = new Vector3((float)Dir, 1, 1);
        }
    }
}
