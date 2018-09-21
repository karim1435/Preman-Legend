using Assets.Scripts.Characterrr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Inputs
{
    public class InputState:MonoBehaviour
    {
        public Direction direction = Direction.Right;

        private Rigidbody2D body2d;
        private Dictionary<Buttons, ButtonState> buttonStates =
            new Dictionary<Buttons, ButtonState>();
        void Awake()
        {
            body2d = GetComponent<Rigidbody2D>();
        }
        public void SetButtonValue(Buttons key, bool value)
        {
            if (!buttonStates.ContainsKey(key))
                buttonStates.Add(key, new ButtonState());

            var state = buttonStates[key];

            if (state.value && !value)
                state.holdTime = 0;

            else if (state.value && value)
                state.holdTime += Time.deltaTime;

            state.value = value;
        }
        public bool GetButtonValue(Buttons key)
        {
            if (buttonStates.ContainsKey(key))
                return buttonStates[key].value;
            else
                return false;
        }
        public float GetButtonHoldTime(Buttons key)
        {
            if (buttonStates.ContainsKey(key))
                return buttonStates[key].holdTime;
            else
                return 0;
        }
    }
}
