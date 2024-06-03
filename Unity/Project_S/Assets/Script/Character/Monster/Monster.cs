using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Monster : MonoBehaviour
{
    [SerializeField] MONSTER_TYPE monsterType;

    public Monster_AbilityData ability;
    public Monster_Resource resource;


    //������Ʈ�ӽſ��� ���͸� ����ֱ� ������, �÷��״� ���⼭ ��������
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
        Debug.Log("����_B ���� �ִϸ��̼� ����");
        isAttacking = false;
    }

    void IsDeadEnd()
    {
        Debug.Log("���� B ���� �ִϸ��̼� ����");

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
