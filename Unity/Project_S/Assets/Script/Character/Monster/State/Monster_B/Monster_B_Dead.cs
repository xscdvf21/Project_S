using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_B_Dead : BaseMonsterState
{
    private string aniName;
    private Animator animator;

    Monster me;
    public Monster_B_Dead(Monster _me, Animator _animator, string _aniName)
    {
        aniName = _aniName;
        animator = _animator;

        me = _me;

    }
    public override void OnAwake()
    {

    }

    public override void OnEnter()
    {
        if(animator.GetBool(aniName))
            animator.SetBool(aniName, false);

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
