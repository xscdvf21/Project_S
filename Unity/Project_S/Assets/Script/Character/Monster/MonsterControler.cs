using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class MonsterControler : MonoBehaviour
{
    private void FixedUpdate()
    {
        Monster_Move();
    }


    //플레이어를 향해 달려오도록 구현
    public void Monster_Move()
    {
        if (Game_Mgr.Instance.mainPlayer == null)
            return;

        Player player = Game_Mgr.Instance.mainPlayer;
        Vector2 vDir = (player.transform.position - transform.position).normalized;

        float distance = Vector2.Distance(player.transform.position, transform.position);

        if (distance > 1f)
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
}

