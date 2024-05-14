using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 인게임 플레이 관련 매니저
/// </summary>
public class InGame_Mgr : MonoBehaviour
{
    private static InGame_Mgr instance = null;

    public static InGame_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }

        instance = this;
    }

    private void Start()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        if (!Object_Mgr.Instance)
            return;

        GameObject player = Instantiate(Resources.Load("Prefabs/Player/Player_A", typeof(GameObject)) as GameObject);
        player.transform.SetParent(this.transform, false);
        Object_Mgr.Instance.mainPlayer = player.GetComponent<Player>();
     }
}

