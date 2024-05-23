using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class MonsterControler : MonoBehaviour
{

    //생성할 때 자기자신을 들고있는게, 최적화에 좋을거 같아서
    [SerializeField] Monster me;
    [Header("플레이어와 거리")]

    [SerializeField] Player player;
    public float playerDis;


    private bool isAlive;
    private void Awake()
    {
        //
        if (me == null)
            me = GetComponent<Monster>();

        player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

    }
    private void Update()
    {
        DistancePlayer();

    }
    private void FixedUpdate()
    {
        Monster_Move();
    }


    public void TakeDamage(int _damage)
    {
        me.ability.hp -= _damage;
        if (me.ability.hp <= 0)
        {
            Monster_Dead();
        }

        if (Object_Mgr.Instance)
            Object_Mgr.Instance.text_Mgr.ShowDamage(DAMAGE_FONT.DEFAULT, transform.position, _damage.ToString());
    }

    //플레이어를 향해 달려오도록 구현
    public void Monster_Move()
    {
        if (player == null)
            return;

        Vector2 vDir = (player.transform.position - transform.position).normalized;

        float distance = Vector2.Distance(player.transform.position, transform.position);

        if (distance > me.ability.atk_Dis)
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, GetComponent<Monster>().ability.moveSpeed * Time.deltaTime);


    }

    public void Monster_Dead()
    {

        gameObject.SetActive(false);
        isAlive = false;
        Object_Mgr.Instance.monster_Mgr.Monster_Dead(me);

        player.resource.Add_Resource(me.resource.GetExp(), me.resource.GetGold());

    }
    void DistancePlayer()
    {
        if (!Get_Alive())
            return;

        playerDis = Vector2.Distance(this.transform.position, Object_Mgr.Instance.player_Mgr.Get_PlayerPos());
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
}

