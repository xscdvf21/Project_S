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


    //������ ����ġ��, ��差 ��� ����
    [Serializable]
    public class Monster_Resource
    {
        [Header("�÷��̾�� �� ����ġ��")]
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
