using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using InputField = TMPro.TMP_InputField;
public class Lobby_Mgr : MonoBehaviour
{
    private static Lobby_Mgr instance = null;

    public static Lobby_Mgr Instance
    {
        get
        {
            return instance;
        }
    }


    public Login login;
    public Button testBtn;
    //[SerializeField] Button optionBtn;
    //[SerializeField] Button quitBtn;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
    }




    // Start is called before the first frame update
    void Start()
    {
        login.Init();

        testBtn.onClick.AddListener(() =>
        {
            LobbyPopup_Mgr.Instance.closeMsg.ShowMsg("Player Creating... Wait Plase");
            Object_Mgr.Instance.player_Mgr.CreatePlayer();
            Invoke("OnClickStartBtn", 2f);
        });
    }

    // Update is called once per frame
    void Update()
    {
        login.OnUpdate();
    }

    void OnClickStartBtn()
    {
        Loading_Mgr.Instance.NextScene("InGame");
    }

    void OnClickOptionBtn()
    {

    }

    void OnClickQuitBtn()
    {
        Application.Quit();
    }


    [Serializable]
    public class Login
    {
        [SerializeField] InputField id_IF;
        [SerializeField] InputField password_IF;

        [SerializeField] Button loginBtn;


        public void Init()
        {
            
            loginBtn.onClick.AddListener(OnClickLoginBtn);
        }

        public void OnUpdate()
        {
            if(string.IsNullOrEmpty(id_IF.text) || string.IsNullOrEmpty(password_IF.text))
                loginBtn.interactable = false;
            else
                loginBtn.interactable = true;

        }


        private void OnClickLoginBtn()
        {
            if (WebServer_Mgr.Instance == null)
                return;

            WebServer_Mgr.Instance.UserLogin(id_IF.text, password_IF.text);
        }
    }
}
