using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class InputComponent : MonoBehaviour
    {
        public SideDirection SideMovementDirection { get; private set; }

        public void SetSideMovementDirection(int value)
        {
            if (value == 0)
                SideMovementDirection = SideDirection.None;
            else if (value == -1)
                SideMovementDirection = SideDirection.Left;
            else
                SideMovementDirection = SideDirection.Right;
        }
    }
}
