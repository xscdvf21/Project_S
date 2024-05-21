using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mgr : MonoBehaviour
{
    [Header("플레이어 목록 (프리팹)")]
    public Player playerPrefab;

    [SerializeField] Player mainPlayer;
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
}
