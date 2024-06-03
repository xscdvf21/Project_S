using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_A_Controller : BaseMonsterController
{
    [SerializeField] MONSTER_STATE state;
    MonsterStateMachine stateMachine;


    private void Awake()
    {
        InitComponent();
        InitState();
    }
    public override void InitState()
    {
        stateMachine = new MonsterStateMachine(MONSTER_STATE.IDLE, new Monster_A_Idle());
        stateMachine.AddState(MONSTER_STATE.MOVE, new Monster_A_Move());
        stateMachine.AddState(MONSTER_STATE.HIT, new Monster_A_Hit());
        stateMachine.AddState(MONSTER_STATE.DEAD, new Monster_A_Dead());
    }


    public override void Idle()
    {
        if (state != MONSTER_STATE.IDLE)
            SetState(MONSTER_STATE.IDLE);
    }

    public override void Move()
    {
        if (state != MONSTER_STATE.MOVE)
            SetState(MONSTER_STATE.MOVE);
    }
    public override void Attack()
    {
        if (state != MONSTER_STATE.ATTACK)
            SetState(MONSTER_STATE.ATTACK);
    }

    public override void Hit()
    {
        if (state != MONSTER_STATE.HIT)
            SetState(MONSTER_STATE.HIT);
    }

    public override void Dead()
    {
        if (state != MONSTER_STATE.DEAD)
            SetState(MONSTER_STATE.DEAD);
    }

    public override void SetState(MONSTER_STATE _state)
    {
        state = _state;
        stateMachine.ChangeState(_state);
    }
}
