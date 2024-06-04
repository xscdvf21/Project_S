using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_C_Controller : BaseMonsterController
{

    [SerializeField] MONSTER_STATE state;
    MonsterStateMachine stateMachine;

    // Start is called before the first frame update


    private void Awake()
    {
        InitComponent();
        InitState();
    }

    private void Update()
    {
        DistancePlayer();

        if (me.ability.hp <= 0f)
        {
            Dead();
            return;
        }


        if (player == null || player.ability.hp <= 0f)
            Idle();
        else if (playerDis > me.ability.atk_Dis)
            Move();
        else if (playerDis <= me.ability.atk_Dis)
            Attack();

        stateMachine.OnUpdate();
    }

    private void FixedUpdate()
    {
        stateMachine.OnFixedUpdate();
    }


    public override void InitState()
    {
        stateMachine = new MonsterStateMachine(MONSTER_STATE.IDLE, new Monster_C_Idle(animator, "isIdle"));

        stateMachine.AddState(MONSTER_STATE.MOVE, new Monster_C_Move(player.GetComponent<PlayerControler>(), me, animator, "isMove"));
        stateMachine.AddState(MONSTER_STATE.ATTACK, new Monster_C_Attack(player.GetComponent<PlayerControler>(), me, animator, "isAttack"));
        stateMachine.AddState(MONSTER_STATE.DEAD, new Monster_C_Dead(animator, "isDead"));
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
