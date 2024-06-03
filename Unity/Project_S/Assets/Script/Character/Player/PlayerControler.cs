using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerControler : MonoBehaviour
{
    [SerializeField] PLAYER_STATE state;
    [SerializeField] Camera cam;

    //������ �� �ڱ��ڽ��� ����ִ°�, ����ȭ�� ������ ���Ƽ�
    public Player player;
    StateMachine stateMachine;

    public string[] stateNames;
    [SerializeField] Rigidbody2D rb;


    //�����ӿ� ����, ���� �� ��
    public bool isMove = false;
    public bool isAuto = false;
    private bool isAttack = false;

    public Vector2 vMovePos;
    
    //�ּ� �Ÿ� ���� (�ǽð����� ������Ʈ)
    [Header("���� ����� ����")]
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
        //���� ������ �ƴ� ��츸 üũ
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
        //ü���� 0�� ���, �ƹ��͵� ����
        if(player.ability.hp <= 0)
        {
            Player_Dead();
            return;
        }

        
        //�˾��� �۵������� �ƴ��� �ľ� �ؾ��ҵ�
        if(Input.GetMouseButton(0) && !InGamePopup_Mgr.Instance.menu_Popup.Get_IsOpen())
        {
            //�ϴ� �޴���ư�� ������ �� ���� ����
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

        //������ ���Ͱ� ���� ��� ���̵� ����
        if (monster == null)
        {
            Player_Idle();
            isMove = false;
        }
        //���� Ŭ���Ͽ�, ���� ���� �� ���, ����ִ� ���Ͱ� ����
        //����ִ� ���Ͱ� �����ϰ�, ���� Ŭ���Ͽ� �������� �ϰ��
        else if (isMove && monster != null)
            Player_Move();
        //���� �� ���Ͱ� ������, ����ִ� ���Ͱ� �����ϰ�, ���� ���� �� ��� (����� ���Ϳ��� ����)
        else if (!isAttack && monster != null && isAuto)
            Player_AutoMove();
        //��Ÿ� �ȿ� ���� ������� ����
        else if (isAttack)
            Player_Attack();
     
        
    }


    public void SetState(PLAYER_STATE _state)
    {
        state = _state;
        stateMachine.ChangeState(_state);
    }
    //���̵� ����
    public void Player_Idle()
    {
        if(state != PLAYER_STATE.IDLE)
            SetState(PLAYER_STATE.IDLE);
    }

    //������ ����
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

    //���� ����
    public void Player_Attack()
    {
        if(state != PLAYER_STATE.ATTACK)
            SetState(PLAYER_STATE.ATTACK);

    }

    //���� ���� 
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
