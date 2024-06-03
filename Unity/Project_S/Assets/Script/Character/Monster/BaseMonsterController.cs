using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonsterController : MonoBehaviour
{
    public Monster me;
    public Player player;
    public float playerDis;

    public Animator animator;

    public bool isAlive;

    public abstract void InitState();
    //아이들 상태
    public abstract void Idle();

    //움직임
    public abstract void Move();

    //공격
    public abstract void Attack();

    //공격받았을 때
    public abstract void Hit();

    //죽음
    public abstract void Dead();

    public abstract void SetState(MONSTER_STATE _state);
    public void InitComponent()
    {
        //
        if (me == null)
            me = GetComponent<Monster>();

        if (animator == null)
            animator = GetComponent<Animator>();

        if (Object_Mgr.Instance.player_Mgr.Get_MainPlayer() != null)
            player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        isAlive = true;
    }

    //플레이어와의 거리 계산
    public void DistancePlayer()
    {
        if (player == null)
            return;

        playerDis = Vector2.Distance(transform.position, player.transform.position);
    }


    //히트를 어떻게 처리해야할까
    public void TakeDamage(int _damage)
    {
        me.ability.hp -= _damage;

        if (Object_Mgr.Instance)
            Object_Mgr.Instance.text_Mgr.ShowDamage(DAMAGE_FONT.DEFAULT, transform.position, _damage.ToString());


    }
}
