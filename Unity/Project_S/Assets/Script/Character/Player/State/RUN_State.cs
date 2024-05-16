using UnityEngine;

public class RUN_State : BaseState
{
    Player player;
    PlayerControler controler;

    [SerializeField] string aniName;
    [SerializeField] Animator animator;

    public RUN_State()
    {

    }

    public RUN_State(Player _player, PlayerControler _controler, Animator _animator, string _aniName)
    {
        player = _player;
        controler = _controler;
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

    }

    public override void OnUpdate()
    {

    }
}

