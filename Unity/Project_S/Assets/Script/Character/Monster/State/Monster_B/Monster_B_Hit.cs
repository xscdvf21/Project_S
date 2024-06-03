using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_B_Hit : BaseMonsterState
{
    private string aniName;
    private Animator animator;
    public Monster_B_Hit(Animator _animator, string _aniName)
    {
        aniName = _aniName;
        animator = _animator;
    }
    public override void OnAwake()
    {

    }

    public override void OnEnter()
    {
        animator.SetTrigger(aniName);
    }

    public override void OnExit()
    {
       
    }

    public override void OnUpdate()
    {

    }
    public override void OnFixedUpdate()
    {

    }
}
