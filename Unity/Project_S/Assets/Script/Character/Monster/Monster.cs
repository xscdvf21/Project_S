using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Monster : MonoBehaviour
{
    [SerializeField] MONSTER_TYPE monsterType;

    public Monster_AbilityData ability;
    public Monster_Resource resource;


    //스테이트머신에서 몬스터를 들고있기 때문에, 플래그는 여기서 관리하자
    private bool isAttacking = false;
    private bool isAlive;
    // Start is called before the first frame update

    private void Awake()
    {
        isAlive = true;
    }
    void Start()
    {
        
    }


    public void SetAlive(bool _b)
    {
        isAlive = _b;
    }
    public void SetAttacking(bool _b)
    {
        isAttacking = _b;
    }


    public bool GetAttacking()
    {
        return isAttacking;
    }
    void IsAttackingEnd()
    {
        Debug.Log("몬스터_B 공격 애니메이션 종료");
        isAttacking = false;
    }

    void IsDeadEnd()
    {
        Debug.Log("몬스터 B 죽음 애니메이션 종료");

        isAlive = false;
        gameObject.SetActive(false);
        Object_Mgr.Instance.monster_Mgr.Monster_Dead(this);
    }
    // Update is called once per frame

    [Serializable]
    public class Monster_AbilityData
    {
        public int atk;
        public float atk_Dis;
        public int attackSpeed;
        public int hp;
        public int maxHp;
        public int moveSpeed;
    }


    //몬스터의 경험치량, 골드량 등등 관리
    [Serializable]
    public class Monster_Resource
    {
        [Header("플레이어에게 줄 경험치량")]
        public int exp;
        public int gold;

        public int GetExp()
        {
            return exp;
        }

        public int GetGold()
        {
            return gold;
        }
    }


}
