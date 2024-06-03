using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class RUN_State : BaseState
{
    Player player;
    PlayerControler controller;

    [SerializeField] string aniName;
    [SerializeField] Animator animator;


    public RUN_State()
    {

    }

    public RUN_State(Player _player, PlayerControler _controller, Animator _animator, string _aniName)
    {
        player = _player;
        controller = _controller;
        animator = _animator;
        aniName = _aniName;
    }


    public override void OnAwake()
    {

    }

    public override void OnEnter()
    {
        animator.SetBool(aniName, true);
    }

    public override void OnExit()
    {
        animator.SetBool(aniName, false);
    }

    public override void OnFixedUpdate()
    {
        if (controller.isMove)
            ClickMove();
        else if (controller.isAuto)
            AutoMove();
    }

    public override void OnUpdate()
    {
    }
    private void ClickMove()
    {
        controller.transform.position = Vector2.MoveTowards(controller.transform.position, controller.vMovePos, player.ability.move_Speed * Time.deltaTime);
        if ((Vector2)controller.transform.position == controller.vMovePos)
        {
            controller.isMove = false;
        }

    }
    private void AutoMove()
    {

        if (controller.transform.position.x < controller.monster.transform.position.x)
            controller.transform.localScale = new Vector3(-1f, 1f, 1f);
        else
            controller.transform.localScale = new Vector3(1f, 1f, 1f);


        controller.transform.position = Vector2.MoveTowards(controller.transform.position, controller.monster.transform.position, player.ability.move_Speed * Time.deltaTime);


    }
}

