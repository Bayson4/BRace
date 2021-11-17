using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class MovementComponent : MonoBehaviour
    {
        private const float ForwardMovementSpeed = 3f;
        private const float SideMovementSpeed = 2f;

        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private InputComponent _input;

        private Vector3 _movementShift;
        private bool _movementEnabled = true;

        public void EnableMovement(bool value)
        {
            _movementEnabled = value;
        }

        private void CalculateForwardMovement()
        {
            _movementShift.z = ForwardMovementSpeed;
        }

        private void CalculateSideMovement()
        {
            if (_input.SideMovementDirection == SideDirection.None)
                return;

            int dir = _input.SideMovementDirection == SideDirection.Left ? -1 : 1;
            _movementShift.x = dir * SideMovementSpeed;
        }

        private void FixedUpdate()
        {
            if (_movementEnabled)
            {
                CalculateForwardMovement();
                CalculateSideMovement();

                _rigidbody.MovePosition(transform.position + _movementShift * Time.fixedDeltaTime);
            }
        }
    }
}