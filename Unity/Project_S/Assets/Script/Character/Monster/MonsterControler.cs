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
    public float playerDis;

    private void Awake()
    {
        //
        if (me == null)
            me = GetComponent<Monster>();

    }
    private void Update()
    {
        DistancePlayer();

    }
    private void FixedUpdate()
    {
        Monster_Move();
    }


    //플레이어를 향해 달려오도록 구현
    public void Monster_Move()
    {
        if (Object_Mgr.Instance.player_Mgr.mainPlayer == null)
            return;

        Player player = Object_Mgr.Instance.player_Mgr.mainPlayer;

        Vector2 vDir = (player.transform.position - transform.position).normalized;

        float distance = Vector2.Distance(player.transform.position, transform.position);

        if (distance > me.ability.atk_Dis)
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, GetComponent<Monster>().ability.moveSpeed * Time.deltaTime);


    }

    /// <summary>
    /// 다른방법을 생각해봐야할듯
    /// </summary>
    /// <param name="collision"></param>
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.transform.tag == "Monster")
    //    {

    //        transform.Translate(Vector3.up * 1f);

    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.transform.tag == "Mosnter")
    //        transform.Translate(Vector3.back * (Time.deltaTime * GetComponent<Monster>().ability.moveSpeed ));
    //}

    void DistancePlayer()
    {
        if (!me.Get_Alive())
            return;

        playerDis = Vector2.Distance(this.transform.position, Object_Mgr.Instance.player_Mgr.Get_PlayerPos());
    }
}

