using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �÷��̾�, ���͵��� ��ų���� ���� ���� ������ ��� ��
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
