using UnityEngine;
using System.Collections;
namespace Assets.Scripts.Inputs
{
    public class InputManager : MonoBehaviour
    {
        public InputAxisState[] inputs;
        public InputState inputState;
        void Update()
        {
            foreach (var input in inputs)
            {
                inputState.SetButtonValue(input.button,input.Value);
            }
        }
    }
}
