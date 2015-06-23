using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

   // public Camera cam;
    GameObject spawn;
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
        if (GUI.Button(new Rect(new Rect(0, 0, 90, 20)), "refresh"))
        {
            PhotonNetwork.JoinRoom("epita", false);
        }
    }

    public void OnPhotonRandomJoinFailed()
    {
        Debug.Log("OnPhotonRandomJoinFailed()");
        PhotonNetwork.CreateRoom("epita", new RoomOptions() { maxPlayers = 4 }, null);
    }
    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        Debug.LogError("Cause: " + cause);
    }
    public void OnJoinedRoom()
    {
        Debug.Log("OnJoinedRoom()");
        SpawnPlayer();
    }

    public void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby()");
        PhotonNetwork.JoinRandomRoom();
    }

    public void OnConnectedToMaster()
    {
        if (PhotonNetwork.networkingPeer.AvailableRegions != null) Debug.LogWarning("List of available regions counts " + PhotonNetwork.networkingPeer.AvailableRegions.Count + ". First: " + PhotonNetwork.networkingPeer.AvailableRegions[0] + " \t Current Region: " + PhotonNetwork.networkingPeer.CloudRegion);
        Debug.Log("OnConnectedToMaster()");
        PhotonNetwork.JoinRandomRoom();
    }
     public void OnPhotonRandomJoin()
    {
        Debug.Log("OnPhotonRandomJoin()");
    }
    void SpawnPlayer()
     {
         //Random rdn = new Random();
         GameObject[] tab = GameObject.FindGameObjectsWithTag("spawn");
         if(PhotonNetwork.isMasterClient)
         {
             spawn = tab[0];
         }
         else
         {
             spawn = tab[3];
         }
         PhotonNetwork.Instantiate("player", spawn.transform.position, Quaternion.identity, 0);
        // cam.enabled = false;
         Debug.Log("spawn");
     }
}
