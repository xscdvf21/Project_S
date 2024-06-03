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
    //���̵� ����
    public abstract void Idle();

    //������
    public abstract void Move();

    //����
    public abstract void Attack();

    //���ݹ޾��� ��
    public abstract void Hit();

    //����
    public abstract void Dead();

    public abstract void SetState(MONSTER_STATE _state);
    public void InitComponent()
    {
        //
        if (me == null)
            me = GetComponent<Monster>();

        if(Object_Mgr.Instance.player_Mgr.Get_MainPlayer() != null)
            player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        isAlive = true;
    }

    //�÷��̾���� �Ÿ� ���
    public void PlayerDistance(Vector2 _vPos, Vector2 _playerPos)
    {
        playerDis = Vector2.Distance(_vPos, _playerPos);
    }
}
