using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_B_Fly : BaseMonsterState
{

    private string aniName;
    private Animator animator;
    public Monster_B_Fly(Animator _animator, string _aniName)
    {
        aniName = _aniName;
        animator = _animator;
    }
    public override void OnAwake()
    {

    }

    public override void OnEnter()
    {
        animator.SetBool(aniName, true);
    }

    public override void OnExit()
    {
        animator.SetBool(aniName, false);
    }

    public override void OnUpdate()
    {

    }
    public override void OnFixedUpdate()
    {

    }
}
