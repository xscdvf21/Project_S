using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_C_Attack : BaseMonsterState
{
    private string aniName;
    private Animator animator;

    Monster me;
    PlayerControler playerController;
    public Monster_C_Attack(PlayerControler _playerController, Monster _me, Animator _animator, string _aniName)
    {
        aniName = _aniName;
        animator = _animator;

        me = _me;
        playerController = _playerController;


    }
    public override void OnAwake()
    {

    }

    public override void OnEnter()
    {

    }

    public override void OnUpdate()
    {

    }

    public override void OnFixedUpdate()
    {

    }

    public override void OnExit()
    {

    }
}
