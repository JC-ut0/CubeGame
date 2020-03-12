using Photon.Pun;
using UnityEngine;

public class Launcher : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Connected");

        PhotonNetwork.JoinOrCreateRoom("Room", new Photon.Realtime.RoomOptions() { MaxPlayers = 4 }, default);
    }


}