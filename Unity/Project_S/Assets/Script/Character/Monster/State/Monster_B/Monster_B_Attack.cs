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

    private bool isAttacking;


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

        delTime = me.ability.attackSpeed;
        isAttacking = false;
    }

    public override void OnExit()
    {
        animator.SetBool(aniName, false);
    }

    public override void OnUpdate()
    {
        delTime -= Time.deltaTime;


        //공격
        if(delTime <= 0f)
        {
            Debug.Log("플레이어 공격 데미지: " + me.ability.atk);

            animator.SetBool(aniName, true);
            playerController.TakeDamage(me.ability.atk);
            delTime = me.ability.attackSpeed;
                        
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

        isAttacking = false;
        delTime = me.ability.attackSpeed;
    }
}
