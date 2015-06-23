using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Connect();
	}

    void Connect()
    {
        PhotonNetwork.ConnectUsingSettings("Epit'S'cape");
        Debug.Log("connect");
    }
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
}
