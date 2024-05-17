using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Monster : MonoBehaviour
{
    [SerializeField] protected MONSTER_TYPE _type;
    public Monster_AbilityData ability;

    private bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int _damage)
    {
        ability.hp -= _damage;      
        DeathCheck();

        if (Object_Mgr.Instance)
            Object_Mgr.Instance.text_Mgr.ShowDamage(DAMAGE_FONT.DEFAULT ,transform.position, _damage.ToString());
    }

    public void DeathCheck()
    {
        if (ability.hp <= 0)
        {
            gameObject.SetActive(false);
            isAlive = false;
            Object_Mgr.Instance.monster_Mgr.Monster_Dead(this);
        }
    }
    

    public void Set_Alive(bool _alive)
    {
        gameObject.SetActive(true);
        isAlive = _alive;
    }

    public bool Get_Alive()
    {
        return isAlive;
    }
    public void Set_Pos(Vector2 _vPos)
    {
        transform.position = _vPos;
    }
    // Update is called once per frame

    [Serializable]
    public class Monster_AbilityData
    {
        public int atk;
        public float atk_Dis;

        public int attackSpeed;

        
        [Header("플레이어에게 줄 경험치량")]
        public int exp;

        [Space(30)]
        public int hp;
        public int maxHp;

        public int moveSpeed;

    }


}
