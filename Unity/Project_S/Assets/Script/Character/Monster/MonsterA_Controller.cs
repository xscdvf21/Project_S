using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterA_Controller : BaseMonsterController
{

    private void Awake()
    {
        InitComponent();
    }


    //아이들 상태
    public override void Idle()
    {

    }

    //움직임
    public override void Move()
    {

    }

    //공격
    public override void Attack()
    {

    }

    //공격받았을 때
    public override void Hit()
    {

    }


    //죽음
    public override void Dead()
    {

    }

    public override void InitState()
    {
    }

    public override void SetState(MONSTER_STATE _state)
    {
    }
}
