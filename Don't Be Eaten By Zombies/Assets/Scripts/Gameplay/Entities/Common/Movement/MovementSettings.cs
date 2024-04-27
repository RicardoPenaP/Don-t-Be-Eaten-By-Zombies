using UnityEngine;

namespace Gameplay.Entities.Common.Movement
{
    [CreateAssetMenu(fileName = "MovementSettings", menuName = "Gameplay/Entities/Common/Movement/MovementSettings")]
    public class MovementSettings : ScriptableObject
    {
        [Header("Movement Settings")]
        [SerializeField] private float forwardSpeed = 5f;
        [SerializeField] private float backwardSpeed = 5f;

        public float ForwardSpeed => forwardSpeed;
        public float BackwardSpeed => backwardSpeed;

    }
}