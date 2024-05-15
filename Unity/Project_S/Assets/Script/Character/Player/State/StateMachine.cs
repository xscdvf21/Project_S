using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StateMachine
{
    BaseState currentState;
    Dictionary<PLAYER_STATE, BaseState> dic_State = new Dictionary<PLAYER_STATE, BaseState>();

    public StateMachine(PLAYER_STATE _key, BaseState _state)
    {
        if(!dic_State.ContainsKey(_key))
        {
            currentState = _state;
            AddState(_key, _state);
            
            currentState.OnEnter();
        }
    }

    public void AddState(PLAYER_STATE _key, BaseState _state)
    {
        if (!dic_State.ContainsKey(_key))
        {
            dic_State.Add(_key, _state);
            _state.OnAwake();
        }
    }

    public void ChangeState(PLAYER_STATE _key)
    {
        currentState.OnExit();

        if(dic_State.TryGetValue(_key, out BaseState _state))
        {
            currentState = _state;
            currentState.OnEnter();
        }
    }

    public void RemoveState(PLAYER_STATE _key)
    {
        if (dic_State.ContainsKey(_key))
            dic_State.Remove(_key);
    }



}

