using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mgr : MonoBehaviour
{
    [Header("플레이어 목록 (프리팹)")]
    public Player playerPrefab;


    [SerializeField] Player mainPlayer;
    private void Awake()
    {
        
    }
    public void CreatePlayer(Transform _parent, Vector2 _vPos)
    {
        if (playerPrefab == null)
            return;

        GameObject player = Instantiate(playerPrefab.gameObject);

        player.transform.position = _vPos;
        player.transform.SetParent(_parent, false);

        mainPlayer = player.GetComponent<Player>();

        mainPlayer.ability = Game_Mgr.Instance.player_save.GetAbility();
        mainPlayer.skill = Game_Mgr.Instance.player_save.GetSkill();
        mainPlayer.items = Game_Mgr.Instance.player_save.GetItems();
        mainPlayer.resource = Game_Mgr.Instance.player_save.Get_Resource();

        Game_Mgr.Instance.SetDataLoad(true);

    }

    public void CreatePlayer()
    {
        if (mainPlayer != null)
            return;

        GameObject player = Instantiate(playerPrefab.gameObject);
        player.SetActive(false);

        DontDestroyOnLoad(player);


        mainPlayer = player.GetComponent<Player>();

        mainPlayer.ability = Game_Mgr.Instance.player_save.GetAbility();
        mainPlayer.skill = Game_Mgr.Instance.player_save.GetSkill();
        mainPlayer.items = Game_Mgr.Instance.player_save.GetItems();
        mainPlayer.resource = Game_Mgr.Instance.player_save.Get_Resource();

        Game_Mgr.Instance.SetDataLoad(true);

    }

    public Player Get_MainPlayer()
    {
        return mainPlayer;
    }

    public Vector2 Get_PlayerPos()
    {
        return mainPlayer.transform.position;
    }

    public void Set_PlayerPos(Transform _parent ,Vector2 _vPos)
    {
        mainPlayer.gameObject.SetActive(true);

        mainPlayer.transform.position = _vPos;
        mainPlayer.transform.SetParent(_parent, false);
    }
}
