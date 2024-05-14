using UnityEngine;

public class DEAD_State : BaseState
{
    [SerializeField] string aniName;
    [SerializeField] Animator animator;

    public DEAD_State()
    {

    }

    public DEAD_State(Animator _animator, string _aniName)
    {
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

