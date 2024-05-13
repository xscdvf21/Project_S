using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 플레이어, 몬스터들을 스킬들을 보관 각각 꺼내서 사용 함
/// </summary>
public class Skill_Mgr : MonoBehaviour
{

    private static Skill_Mgr instance = null;

    public static Skill_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public Player_Skill player_Skill;
    public Monster_Skill monster_Skill;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
