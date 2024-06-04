using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_C_Dead : BaseMonsterState
{
    private string aniName;
    private Animator animator;

    public Monster_C_Dead(Animator _animator, string _aniName)
    {
        aniName = _aniName;
        animator = _animator;
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
