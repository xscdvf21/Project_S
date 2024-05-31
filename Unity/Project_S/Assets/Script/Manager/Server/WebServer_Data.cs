using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �� ������ ��� �� ������ 
/// </summary>
public class WebServer_Data : MonoBehaviour
{
    public WebServer_User userData;
    public WebServer_Ability_Resuource ab_resData;
    public WebServer_Item itemData;
    public WebServer_Skill skillData;

}

/// <summary>
/// ���� �α��� ���� �� ĳ�� ������
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
/// ���� �ɷ�ġ ������ �� ��ȭ(���) ����Ʈ ���� ����
/// </summary>
[Serializable]
public class WebServer_Ability_Resuource
{
    [SerializeField] string dummy;
}

/// <summary>
/// ���� ������ ������
/// </summary>
[Serializable]
public class WebServer_Item
{
    [SerializeField] string dummy;
}

/// <summary>
/// ���� ��ų ������
/// </summary>
[Serializable]
public class WebServer_Skill
{
    [SerializeField] string dummy;
}
