using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 웹 서버와 통신 할 데이터 
/// </summary>
public class WebServer_Data : MonoBehaviour
{
    public WebServer_User userData;
    public WebServer_Ability_Resuource ab_resData;
    public WebServer_Item itemData;
    public WebServer_Skill skillData;

}

/// <summary>
/// 유저 로그인 정보 및 캐쉬 보유량
/// </summary>
[Serializable] 
public class WebServer_User
{
    public string userID;
    public string password;
    public string userName;
    public DateTime date;
}

/// <summary>
/// 유저 능력치 데이터 및 재화(골드) 퀘스트 진행 사항
/// </summary>
[Serializable]
public class WebServer_Ability_Resuource
{
    [SerializeField] string dummy;
}

/// <summary>
/// 유저 아이템 보유량
/// </summary>
[Serializable]
public class WebServer_Item
{
    [SerializeField] string dummy;
}

/// <summary>
/// 유저 스킬 보유량
/// </summary>
[Serializable]
public class WebServer_Skill
{
    [SerializeField] string dummy;
}
