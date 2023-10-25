using UnityEngine;

namespace SpiritOfTheRisingSunMovementSystem
{

    public class PlayerAttackState : PlayerGroundedState
    {
        float timePassed;
        float clipLength;
        float clipSpeed;
        bool attack;

        public PlayerAttackState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            attack = false;
            stateMachine.Player.Animator.applyRootMotion = true;
            timePassed = 0f;
            stateMachine.Player.Animator.SetFloat("speed", 0f);
        }

        public override void Update()
        {
            base.Update();

            timePassed += Time.deltaTime;
            clipLength = stateMachine.Player.Animator.GetCurrentAnimatorClipInfo(1)[0].clip.length;
            clipSpeed = stateMachine.Player.Animator.GetCurrentAnimatorStateInfo(1).speed;

            if (timePassed >= clipLength / clipSpeed && attack)
            {
                //stateMachine.ChangeState(stateMachine.CombatAttackState);
            }
            if (timePassed >= clipLength / clipSpeed)
            {
                stateMachine.ChangeState(stateMachine.CombatIdlingState);
                //stateMachine.Player.Animator.SetBool("attack", false);
                stateMachine.Player.Animator.SetBool("isIdling", true);
            }
        }

        public override void Exit()
        {
            base.Exit();
            stateMachine.Player.Animator.applyRootMotion = false;
        }
    }
}
