namespace SpiritOfTheRisingSunMovementSystem
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public Player Player { get; }
        public PlayerStateReusableData ReusableData { get; }

        public PlayerIdlingState IdlingState { get; }

        public PlayerCombatIdlingState CombatIdlingState { get; }
        public PlayerAttackState CombatAttackState { get; }

        public PlayerWalkingState WalkingState { get; }
        public PlayerRunningState RunningState { get; }
        public PlayerSprintingState SprintingState { get; }

        public PlayerJumpingState JumpingState { get; }

        public PlayerMovementStateMachine(Player player)
        {
            Player = player;
            ReusableData = new PlayerStateReusableData();

            IdlingState = new PlayerIdlingState(this);

            CombatIdlingState = new PlayerCombatIdlingState(this);
            CombatAttackState = new PlayerAttackState(this);

            WalkingState = new PlayerWalkingState(this);
            RunningState = new PlayerRunningState(this);
            SprintingState = new PlayerSprintingState(this);

            JumpingState = new PlayerJumpingState(this);
        }
    }
}



