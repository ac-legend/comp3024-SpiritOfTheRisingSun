using UnityEngine;
using UnityEngine.InputSystem;

namespace SpiritOfTheRisingSunMovementSystem
{
    public class PlayerSprintingState : PlayerMovingState
    {
        private float startTime;

        private bool keepSprinting;
        private bool shouldResetSprintState;

        public PlayerSprintingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            stateMachine.ReusableData.MovementSpeedModifier = groundedData.SprintData.SpeedModifier;

            base.Enter();

            StartAnimation(stateMachine.Player.AnimationData.SprintParameterHash);

            stateMachine.ReusableData.CurrentJumpForce = airborneData.JumpData.StrongForce;
        }

        public override void Exit()
        {
            base.Exit();

            StopAnimation(stateMachine.Player.AnimationData.SprintParameterHash);

        }

        protected override void OnSprintStarted(InputAction.CallbackContext context)
        {
            base.OnSprintStarted(context);

            stateMachine.ChangeState(stateMachine.SprintingState);
        }

        protected override void OnMovementCanceled(InputAction.CallbackContext context)
        {
            stateMachine.ChangeState(stateMachine.IdlingState);

            base.OnMovementCanceled(context);
        }
    }
}

