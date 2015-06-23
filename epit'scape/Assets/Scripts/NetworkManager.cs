﻿using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {

	}
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
        if (!PhotonNetwork.connected)
        {
            if (GUILayout.Button("Connect"))
            {
                PhotonNetwork.ConnectUsingSettings("Epit'S'cape v001");
            }
        }
        else
        {
            if (GUILayout.Button("Disconnect"))
            {
                PhotonNetwork.Disconnect();
            }
        }
    }

    public void OnPhotonRandomJoinFailed()
    {
        Debug.Log("OnPhotonRandomJoinFailed()");
        PhotonNetwork.CreateRoom(null, new RoomOptions() { maxPlayers = 4 }, null);
    }
    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        Debug.LogError("Cause: " + cause);
    }
    public void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom()");
    }

    public void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby()");
        PhotonNetwork.JoinRandomRoom();
    }

    public void OnConnectedToMaster()
    {
        if (PhotonNetwork.networkingPeer.AvailableRegions != null) Debug.LogWarning("List of available regions counts " + PhotonNetwork.networkingPeer.AvailableRegions.Count + ". First: " + PhotonNetwork.networkingPeer.AvailableRegions[0] + " \t Current Region: " + PhotonNetwork.networkingPeer.CloudRegion);
        Debug.Log("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
        PhotonNetwork.JoinRandomRoom();
    }
     public void OnPhotonRandomJoin()
    {
        Debug.Log("OnPhotonRandomJoin()");
    }
}
