using UnityEngine;
using System.Collections;
namespace Assets.Scripts.Characterrr
{
    public class Player : Character
    {
        private static Player _instance;
        public static Player Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<Player>();

                    if (_instance == null)
                    {
                        GameObject singleton = new GameObject(typeof(Player).Name);
                        _instance = singleton.AddComponent<Player>();
                    }
                }
                return _instance;
            }
        }
    }
}

