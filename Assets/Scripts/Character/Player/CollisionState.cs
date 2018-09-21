using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Characterrr
{
    public class CollisionState:MonoBehaviour
    {
        [SerializeField]
        private LayerMask collisionLayer;
        [SerializeField]
        private bool standing;
        [SerializeField]
        private Vector2 bottomPosition=Vector2.zero;
        [SerializeField]

        private float collisionRadius = 10f;
        public bool Standing { get { return standing; } }
        void FixedUpdate()
        {
            var positionOnGround = bottomPosition;
            positionOnGround.x += transform.position.x;
            positionOnGround.y += transform.position.y;

            standing = Physics2D.OverlapCircle(positionOnGround, collisionRadius,collisionLayer);
        }
        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            var pos = bottomPosition;
            pos.x += transform.position.x;
            pos.y += transform.position.y;

            Gizmos.DrawWireSphere(pos, collisionRadius);
        }
    }
}
