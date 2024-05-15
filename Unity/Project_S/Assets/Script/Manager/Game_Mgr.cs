using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� �� �����͸� ������ ��ü
/// �ɼ�, �ھ���� ���
/// </summary>
public class Game_Mgr : MonoBehaviour
{
    private static Game_Mgr instance = null;

    public static Game_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public Player mainPlayer;

    public List<Monster> list_Monster;
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

    public void MonsterAdd(Monster _monster)
    {
        list_Monster.Add(_monster);
    }


}
