using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerControler : MonoBehaviour
{
    [SerializeField] PLAYER_STATE state;
    public Player player;

    Camera cam;
    StateMachine stateMachine;

    public string[] stateNames;


    [SerializeField] Rigidbody2D rb;
    //움직임에 대한, 변수 및 불
    private bool isMove = false;
    private Vector2 vMovePos;
    
    private void Awake()
    {
        if (player == null)
            player = GetComponent<Player>();

        if (rb == null)
            rb = GetComponent<Rigidbody2D>();

        cam = Camera.main;

        InitState();

    }

    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        CameraFix();
        Player_KeyInput();
    }
    void InitState()
    {
        Animator animator = GetComponentInChildren<Animator>();

        stateMachine = new StateMachine(PLAYER_STATE.IDLE, new IDLE_State(animator, stateNames[(int)PLAYER_STATE.IDLE]));
        stateMachine.AddState(PLAYER_STATE.RUN, new RUN_State(animator, stateNames[(int)PLAYER_STATE.RUN]));
        stateMachine.AddState(PLAYER_STATE.ATTACK, new ATTACK_State(animator, stateNames[(int)PLAYER_STATE.ATTACK]));
        stateMachine.AddState(PLAYER_STATE.DEAD, new DEAD_State(animator, stateNames[(int)PLAYER_STATE.DEAD]));
    }

    void CameraFix()
    {
        Vector2 vPos = player.GetComponent<RectTransform>().anchoredPosition;
        cam.transform.position = new Vector3(vPos.x, vPos.y, cam.transform.position.z);
    }

    public void SetState(PLAYER_STATE _state)
    {
        state = _state;
        stateMachine.ChangeState(_state);
    }
    //아이들 상태
    public void Player_Idle()
    {
        if(state != PLAYER_STATE.IDLE)
            SetState(PLAYER_STATE.IDLE);


    }

    //움직임 상태
    public void Player_Move()
    {

        if(state != PLAYER_STATE.RUN)
        {
            SetState(PLAYER_STATE.RUN);
        }

        transform.position = Vector2.MoveTowards(transform.position, vMovePos, GetComponent<Player>().ability.moveSpeed * Time.deltaTime);

        if ((Vector2)transform.position == vMovePos)
        {
            isMove = false;
            SetState(PLAYER_STATE.IDLE);
            return;
        }
    }

    //공격 상태
    public void Player_Attack()
    {
        SetState(PLAYER_STATE.ATTACK);
    }

    //죽음 상태 
    public void Player_Dead()
    {
        SetState(PLAYER_STATE.DEAD);
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
        else
            Player_Idle();
        
    }
}
