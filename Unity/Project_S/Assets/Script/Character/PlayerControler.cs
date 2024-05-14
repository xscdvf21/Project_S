using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerControler : MonoBehaviour
{
    [SerializeField] PLAYER_STATE state;
    public Animator animator;
    public string[] stateNames;

    Camera cam;


    //�����ӿ� ����, ���� �� ��
    private bool isMove = false;
    private Vector2 vMovePos;
    
    private void Awake()
    {
        if (animator == null)
            animator = GetComponentInChildren<Animator>();

        cam = Camera.main;
    }


    //���̵� ����
    public void Player_Idle()
    {
        state = PLAYER_STATE.IDLE;
        animator.SetBool(stateNames[(int)state], true);
    }

    //������ ����
    public void Player_Move()
    {

        if(state != PLAYER_STATE.RUN)
        {
            state = PLAYER_STATE.RUN;
            animator.SetBool(stateNames[(int)state], true);
        }

        if ((Vector2)transform.position == vMovePos)
        {
            isMove = false;
            return;
        }

        transform.position = Vector2.MoveTowards(transform.position, vMovePos, GetComponent<Player>().ability.moveSpeed * Time.deltaTime);    
      
    }

    //���� ����
    public void Player_Attack()
    {
        state = PLAYER_STATE.ATTACK;
        animator.SetBool(stateNames[(int)state], true);
    }

    //���� ���� 
    public void Player_Dead()
    {
        state = PLAYER_STATE.DEAD;
        animator.SetBool(stateNames[(int)state], true);
    }

    private void FixedUpdate()
    {
        Player_KeyInput();
    }
    public void Player_KeyInput()
    {
        if(Input.GetMouseButton(0))
        {
            isMove = true;
            vMovePos = cam.ScreenToWorldPoint(Input.mousePosition);           

        }

        if (isMove)
            Player_Move();

        
    }
    

}
