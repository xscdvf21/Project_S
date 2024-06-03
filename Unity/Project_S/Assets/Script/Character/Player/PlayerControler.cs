using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerControler : MonoBehaviour
{
    [SerializeField] PLAYER_STATE state;
    [SerializeField] Camera cam;

    //생성할 때 자기자신을 들고있는게, 최적화에 좋을거 같아서
    public Player player;
    StateMachine stateMachine;

    public string[] stateNames;
    [SerializeField] Rigidbody2D rb;


    //움직임에 대한, 변수 및 불
    public bool isMove = false;
    public bool isAuto = false;
    private bool isAttack = false;

    public Vector2 vMovePos;
    
    //최소 거리 몬스터 (실시간으로 업데이트)
    [Header("가장 가까운 몬스터")]
    public Monster monster;
    
    private void Awake()
    {
        if (player == null)
            player = GetComponent<Player>();

        if (rb == null)
            rb = GetComponent<Rigidbody2D>();

        InitState();

        cam = Camera_Mgr.Instance.GetCamera();
    }

    private void Update()
    {
        stateMachine.OnUpdate();
    }
    private void FixedUpdate()
    {
        stateMachine.OnFixedUpdate();
        //수동 조작이 아닐 경우만 체크
        if(!isMove)
        {
            isAuto = true;
            isAttack = Attack_Check(player.ability.atk_Dis);
        }

        CameraFix();
        Player_KeyInput();


    }
    void InitState()
    {
        Animator animator = GetComponentInChildren<Animator>();

        stateMachine = new StateMachine(PLAYER_STATE.IDLE, new IDLE_State(player, this, animator, stateNames[(int)PLAYER_STATE.IDLE]));
        stateMachine.AddState(PLAYER_STATE.RUN, new RUN_State(player, this, animator, stateNames[(int)PLAYER_STATE.RUN]));
        stateMachine.AddState(PLAYER_STATE.ATTACK, new ATTACK_State(player, this, animator, stateNames[(int)PLAYER_STATE.ATTACK]));
        stateMachine.AddState(PLAYER_STATE.DEAD, new DEAD_State(player, this, animator, stateNames[(int)PLAYER_STATE.DEAD]));
    }

    void CameraFix()
    {
        if (cam == null)
            return;

        Vector2 vPos = player.GetComponent<RectTransform>().anchoredPosition;
        cam.transform.position = new Vector3(vPos.x, vPos.y, cam.transform.position.z);
    }
    public void Player_KeyInput()
    {
        //체력이 0일 경우, 아무것도 못함
        if(player.ability.hp <= 0)
        {
            Player_Dead();
            return;
        }

        
        //팝업이 작동중인지 아닌지 파악 해야할듯
        if(Input.GetMouseButton(0) && !InGamePopup_Mgr.Instance.menu_Popup.Get_IsOpen())
        {
            //하단 메뉴버튼을 눌렀을 때 막기 위해
            Vector3 vMousePos = Input.mousePosition;
            float screenX = Screen.width / 2f;

            if (vMousePos.y <= 300f)
                return;

            if(vMousePos.x < screenX)
                transform.localScale = new Vector3(1f, 1f, 1f);
            else
                transform.localScale = new Vector3(-1f, 1f, 1f);

            isMove = true;
            isAuto = false;
            isAttack = false;
            
            vMovePos = cam.ScreenToWorldPoint(vMousePos);


        }

        //주위에 몬스터가 없을 경우 아이들 상태
        if (monster == null)
        {
            Player_Idle();
            isMove = false;
        }
        //맵을 클릭하여, 수동 조작 일 경우, 살아있는 몬스터가 존재
        //살아있는 몬스터가 존재하고, 맵을 클릭하여 수동조작 일경우
        else if (isMove && monster != null)
            Player_Move();
        //공격 할 몬스터가 없으며, 살아있는 몬스터가 존재하고, 오토 조작 일 경우 (가까운 몬스터에게 접근)
        else if (!isAttack && monster != null && isAuto)
            Player_AutoMove();
        //사거리 안에 적이 있을경우 공격
        else if (isAttack)
            Player_Attack();
     
        
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

        if (state != PLAYER_STATE.RUN)
            SetState(PLAYER_STATE.RUN);

        if (isMove == false)
        {
            SetState(PLAYER_STATE.IDLE);
            return;
        }


        //if (state != PLAYER_STATE.RUN)
        //    SetState(PLAYER_STATE.RUN);

        //transform.position = Vector2.MoveTowards(transform.position, vMovePos, GetComponent<Player>().ability.move_Speed * Time.deltaTime);

        //if ((Vector2)transform.position == vMovePos)
        //{
        //    isMove = false;
        //    SetState(PLAYER_STATE.IDLE);
        //    return;
        //}
    }
    public void Player_AutoMove()
    {
        if (state != PLAYER_STATE.RUN)
        {
            SetState(PLAYER_STATE.RUN);
        }

        //if (transform.position.x < monster.transform.position.x)
        //    transform.localScale = new Vector3(-1f, 1f, 1f);
        //else
        //    transform.localScale = new Vector3(1f, 1f, 1f);


        //transform.position = Vector2.MoveTowards(transform.position, monster.transform.position, GetComponent<Player>().ability.move_Speed * Time.deltaTime);
    }

    //공격 상태
    public void Player_Attack()
    {
        if(state != PLAYER_STATE.ATTACK)
            SetState(PLAYER_STATE.ATTACK);

    }

    //죽음 상태 
    public void Player_Dead()
    {
        if (state != PLAYER_STATE.DEAD)
            SetState(PLAYER_STATE.DEAD);
    }

    public bool Attack_Check(float _atk_Dis)
    {
        if (Object_Mgr.Instance == null)
            return false;

        monster = Object_Mgr.Instance.monster_Mgr.Get_MinDistanceMonster();

        if (monster == null)
            return false;

        if (monster.GetComponent<BaseMonsterController>().playerDis <= _atk_Dis)
            return true;
        else
            return false;

    }

    public void SetCamera(Camera _camera)
    {
        cam = _camera;
    }

    public void TakeDamage(int _damage)
    {
        player.ability.hp -= _damage;

        if (player.ability.hp <= 0f)
            Player_Dead();
    }
}
