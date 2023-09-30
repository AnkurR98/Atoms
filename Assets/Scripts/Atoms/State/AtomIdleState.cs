using UnityEngine;

public class AtomIdleState : AtomBaseState
{

    public AtomIdleState(AtomStateMachine stateMachine) : base(stateMachine) { }

    public override void OnStateEnter()
    {
        
    }

    public override void OnStateExit()
    {
        
    }

    public override void Tick()
    {
        if(Vector3.Distance(PlayerService.Instance._player.transform.position, _atomSM.transform.position) < 5f)
        {
            _atomSM.ChangeAtomState(AtomState.ACTIVATED);
        }
    }
}