using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CharacterA : Player
{

    [SerializeField] PLAYER_STATE state;
    StateMachine stateMachine;




    private void Awake()
    {
        base.Init();
        InitState();
    }
    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        OnFixedUpdate();
    }


    void InitState()
    {
        stateMachine = new StateMachine(PLAYER_STATE.IDLE, new IDLE_State());
        stateMachine.AddState(PLAYER_STATE.RUN, new RUN_State());
        stateMachine.AddState(PLAYER_STATE.ATTACK, new ATTACK_State());
        stateMachine.AddState(PLAYER_STATE.SKILL, new SKILL_State());
        stateMachine.AddState(PLAYER_STATE.DEAD, new DEAD_State());
    }

    public void SetState(PLAYER_STATE _state)
    {
        state = _state;
        stateMachine.ChangeState(_state);
    }

}
