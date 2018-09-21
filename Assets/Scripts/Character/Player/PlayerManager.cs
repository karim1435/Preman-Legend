using Assets.Scripts.Characterrr.Playerss;
using Assets.Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Characterrr
{
    public class PlayerManager:MonoBehaviour
    {
        private CollisionState collisionState;
        private PlayerMovement playerMovement;
        private PlayerShoot playerShoot;
        private PlayerMelee playerMeele;
        private Animator animator;
        private PlayerJump playerJump;
        private PlayerHealth playerHealth;
        void Awake()
        {
            animator = GetComponent<Animator>();
            playerJump = GetComponent<PlayerJump>();          
            playerMovement = GetComponent<PlayerMovement>();
            playerShoot = GetComponent<PlayerShoot>();
            playerMeele = GetComponent<PlayerMelee>();
            collisionState = GetComponent<CollisionState>();
            playerHealth = GetComponent<PlayerHealth>();
        }
        void Update()
        {
            if (collisionState.Standing)
                ChangeAnimation(0);
            if (playerMovement.AbsvelX>0)
                ChangeAnimation(1);
            if (playerMeele.IsAttack)
                ChangeAnimation(2);
            if (playerShoot.IsAttack)
                ChangeAnimation(3);
            if (playerHealth.Attacked)
                ChangeAnimation(4);
            if (playerHealth.Die)
                ChangeAnimation(5);
            if (playerMovement.AbsVely > 0)
                ChangeAnimation(6);
        }
        void ChangeAnimation(int value)
        {
            animator.SetInteger("playerAnimState", value);
        }
    }
}
