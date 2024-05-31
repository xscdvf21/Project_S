using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �ݱ� ��ư�� �ִ� �޼��� â
/// </summary>
public class LobbyPopup_CloseMsg : MonoBehaviour
{

    public Text msgText;
    public Button closeBtn;


    private void Awake()
    {
        closeBtn.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
        });
    }
    // Start is called before the first frame update

    public void ShowMsg(string _msg)
    {
        gameObject.SetActive(true);
        msgText.text = _msg;

    }
}
