using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Monster : MonoBehaviour
{
    [SerializeField] protected MONSTER_TYPE _type;

    public Monster_AbilityData ability;
    public Monster_Resource resource;

    private bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        
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
