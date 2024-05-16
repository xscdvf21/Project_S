using UnityEngine;

public class DEAD_State : BaseState
{
    Player player;
    PlayerControler controler;

    [SerializeField] string aniName;
    [SerializeField] Animator animator;

    public DEAD_State()
    {

    }

    public DEAD_State(Player _player, PlayerControler _controler, Animator _animator, string _aniName)
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

    }

    public override void OnExit()
    {

    }

    public override void OnFixedUpdate()
    {

    }

    public override void OnUpdate()
    {

    }
}

