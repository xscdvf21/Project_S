﻿using UnityEngine;

public class ATTACK_State : BaseState
{
    Player player;
    PlayerControler controler;

    [SerializeField] string aniName;
    [SerializeField] Animator animator;

    private bool isAttacking;
    private float delTime = 0f;
    public ATTACK_State(Player _player, PlayerControler _controler)
    {

    }

    public ATTACK_State(Player _player, PlayerControler _controler, Animator _animator, string _aniName)
    {
        player = _player;
        controler = _controler;
        animator = _animator;
        aniName = _aniName;
    }
    public override void OnAwake()
    {

    }

    public override void OnEnter()
    {
        delTime = 0f;
        isAttacking = false;

    }

    public override void OnExit()
    {
        animator.SetBool(aniName, false);
        Debug.Log("공격 끝");
    }

    public override void OnFixedUpdate()
    {


    }

    public override void OnUpdate()
    {
        if(isAttacking)
        {
            if (controler.transform.position.x < controler.monster.transform.position.x)
                controler.transform.localScale = new Vector3(-1f, 1f, 1f);
            else
                controler.transform.localScale = new Vector3(1f, 1f, 1f);

            delTime += Time.deltaTime;
            if (delTime >= player.ability.atk_Speed)
                ReAttack();

            if(delTime >= 0.4f && animator.GetBool(aniName))
            {
                animator.SetBool(aniName, false);
                controler.monster.GetComponent<BaseMonsterController>().TakeDamage(player.ability.atk);
                Debug.Log("플레이어가 공격 합니다.");
            }
        }

        if (!isAttacking)
        {
            if(animator.GetBool(aniName))
                animator.SetBool(aniName, false);

            animator.SetBool(aniName, true);



            isAttacking = true;
        }

    }

    public void ReAttack()
    {
        
        isAttacking = false;
        delTime = 0f;
    }

 
}

