using System;
using UnityEngine;

namespace SpiritOfTheRisingSunMovementSystem
{
    [Serializable]
    public class PlayerRotationData
    {
        [field: SerializeField] public Vector3 TargetRotationReachTime { get; private set; }
    }
}
