using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Launcher : MonoBehaviourPunCallbacks
{

    string roomName = "My Room";
    bool ShowGUI = true;

    public SteamVR_LaserPointer laserPointer;


    public void OnClick_ConnectBtn()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    private void Awake()
    {
        laserPointer.PointerClick += PointerClick;

        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Keyboard")
        {
            Debug.Log("Keyboard was clicked");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was clicked");
            OnClick_ConnectBtn();
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        PhotonNetwork.LoadLevel("Rooms");
    }
    
}
