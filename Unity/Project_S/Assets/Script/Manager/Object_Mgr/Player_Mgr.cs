using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mgr : MonoBehaviour
{
    [Header("플레이어 목록 (프리팹)")]
    public Player playerPrefab;

    public Player mainPlayer;
    public void CreatePlayer(Transform _parent, Vector2 _vPos)
    {
        if (playerPrefab == null)
            return;

        GameObject player = Instantiate(playerPrefab.gameObject);

        player.transform.position = _vPos;
        player.transform.SetParent(_parent, false);

        mainPlayer = player.GetComponent<Player>();
    }

    public Player Get_MainPlayer()
    {
        return mainPlayer;
    }
}
