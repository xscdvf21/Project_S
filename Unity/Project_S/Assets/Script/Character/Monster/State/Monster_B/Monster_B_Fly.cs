using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_B_Fly : BaseMonsterState
{

    private string aniName;
    private Animator animator;

    private float moveSpeed;

    Monster me;
    PlayerControler playerController;
    public Monster_B_Fly(PlayerControler _playerController, Monster _me, Animator _animator, string _aniName)
    {
        aniName = _aniName;
        animator = _animator;

        playerController = _playerController;
        me = _me;
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
        if (playerController == null)
            return;

        Vector2 vDir = (playerController.transform.position - me.transform.position).normalized;

        float distance = Vector2.Distance(playerController.transform.position, me.transform.position);
        me.transform.position = Vector2.MoveTowards(me.transform.position, playerController.transform.position, me.ability.moveSpeed * Time.deltaTime);

    }
}
