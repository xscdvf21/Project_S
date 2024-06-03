using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStateMachine : MonoBehaviour
{
    BaseMonsterState currentState;
    Dictionary<MONSTER_STATE, BaseMonsterState> dic_State = new Dictionary<MONSTER_STATE, BaseMonsterState>();

    //처음으로 보여줄 상태
    public MonsterStateMachine(MONSTER_STATE _key, BaseMonsterState _state)
    {
        if(!dic_State.ContainsKey(_key))
        {
            currentState = _state;
            dic_State.Add(_key, _state);

            currentState.OnAwake();
            currentState.OnEnter();
        }

    }

    public void AddState(MONSTER_STATE _key, BaseMonsterState _state)
    {
        if(!dic_State.ContainsKey(_key))
        {
            dic_State.Add(_key, _state);
            _state.OnAwake();
        }
    }

    public void ChangeState(MONSTER_STATE _key)
    {
        currentState.OnExit();

        if(dic_State.TryGetValue(_key, out BaseMonsterState _result))
        {
            currentState = _result;
            currentState.OnEnter();
        }
    }

    public void OnUpdate()
    {
        currentState.OnUpdate();
    }

    public void OnFixedUpdate()
    {
        currentState.OnFixedUpdate();
    }

    public void RemoveState(MONSTER_STATE _key)
    {
        if (dic_State.ContainsKey(_key))
            dic_State.Remove(_key);
    }
}
