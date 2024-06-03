using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_B_Attack : BaseMonsterState
{
    
    private string aniName;
    private Animator animator;

    private float delTime = 0f;

    Monster me;
    PlayerControler playerController;
    public Monster_B_Attack(PlayerControler _playerController, Monster _me, Animator _animator, string _aniName)
    {
        aniName = _aniName;
        animator = _animator;

        me = _me;
        delTime = me.ability.attackSpeed;

        playerController = _playerController;
    }
    public override void OnAwake()
    {

    }

    public override void OnEnter()
    {
        me.SetAttacking(false);
        delTime = me.ability.attackSpeed;
    }

    public override void OnExit()
    {
        animator.SetBool(aniName, false);
    }

    public override void OnUpdate()
    {

        //1.공격안할때만, 시간 체크
        if (me.GetAttacking() == false)
        {
            delTime -= Time.deltaTime;
            if (animator.GetBool(aniName))
                animator.SetBool(aniName, false);


            if (delTime <= 0f)
            {
                //공격
                me.SetAttacking(true);
                animator.SetBool(aniName, true);
                playerController.TakeDamage(me.ability.atk);
            }

        }

    }
    public override void OnFixedUpdate()
    {

    }
    
    public void AnimationEnd()
    {
        Debug.Log("애니메이션 끝남");
    }
    

    public void ReAttack()
    {
        delTime = me.ability.attackSpeed;
    }
}
