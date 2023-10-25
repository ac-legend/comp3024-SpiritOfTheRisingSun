using System;
using UnityEngine;

namespace SpiritOfTheRisingSunMovementSystem
{
    [Serializable]
    public class PlayerAirborneData
    {
        [field: SerializeField] public PlayerJumpData JumpData { get; private set; }
    }
}
