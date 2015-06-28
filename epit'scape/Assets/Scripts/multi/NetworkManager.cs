using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour
{
    public Camera cam;
    GameObject spawn;
    GameObject[] tab_en;
    GameObject[] tab_jou;
    int winneur = 0;
   // float tempsWineur = 0;
    // Use this for initialization
    void Start()
    {
        tab_en = GameObject.FindGameObjectsWithTag("enemy_spawn");
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
        if (GUILayout.Button("Restart"))
        {
            PhotonNetwork.Disconnect();
            PhotonNetwork.ConnectUsingSettings("Epit'S'cape v001");
        }
        GUI.Box(new Rect(400, 0, 90, 20), "Gagant" + winneur);
     //   GUI.Box(new Rect(600, 0, 90, 20), "Temps" + tempsWineur);
        // if (GUI.Button(new Rect(new Rect(0, 0, 90, 20)), "refresh"))


    }
    void Update()
    {
        tab_jou = GameObject.FindGameObjectsWithTag("Player");
        if(tab_jou[0].GetComponent<PlayerHealthMult>().isFinished && tab_jou[1].GetComponent<PlayerHealthMult>().isFinished)
        {
            endGame();
            Debug.Log("fIN");
        }
        else
        {
            Debug.Log("continue");
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
        SpawnEnemies();
        GameObject[] tab = GameObject.FindGameObjectsWithTag("spawn");
        spawn = tab[Random.Range(0, tab.Length)];
        GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate("CarlMultBon", spawn.transform.position, Quaternion.identity, 0);
        cam.enabled = false;
        myPlayer.transform.FindChild("Camera").gameObject.SetActive(true);
        Debug.Log("main camera bon");
        ((MonoBehaviour)myPlayer.GetComponent("PlayerMovement")).enabled = true;
        ((MonoBehaviour)myPlayer.GetComponent("MouseLook")).enabled = true;
        ((MonoBehaviour)myPlayer.GetComponent("Shoot")).enabled = true;
        Debug.Log("spawn");
        
        Debug.Log("spawn_enemies");
    }
    void SpawnEnemies()
    {
        for (int i = 0; i < tab_en.Length; i++)
        {
            spawn = tab_en[i];
            PhotonNetwork.Instantiate("zombmult", spawn.transform.position, Quaternion.identity, 0);
        }
        Debug.Log("spawn_enemies");
    }
    void endGame()
    {
        int gagnant;
        float temps;
        if (tab_jou[0].GetComponent<PlayerHealthMult>().time < tab_jou[1].GetComponent<PlayerHealthMult>().time)
        {
            gagnant = 1;
            temps = tab_jou[0].GetComponent<PlayerHealthMult>().time;
            Debug.Log("PLAYER 1 WIN");
        }
        else
        {
            gagnant = 2;
           // temps = tab_jou[1].GetComponent<PlayerHealthMult>().time;
            Debug.Log("PLAYER 2 WIN");
        }
        //tab_jou[0].GetComponent<Fin>().enabled = true;
        //tab_jou[0].GetComponent<Fin>().winneur = gagnant;
        //tab_jou[0].GetComponent<Fin>().tempsWineur = temps;
        Debug.Log("allez");
        winneur = gagnant;
       // tempsWineur = temps;

        //tab_jou[1].GetComponent<Fin>().enabled = true;
        //tab_jou[0].GetComponent<Fin>().winneur = gagnant;
        //tab_jou[0].GetComponent<Fin>().tempsWineur = temps;

    }



        //while(tab_jou.Length != null)
        //{
        //    StartCoroutine(dead());
        //}
        //int i = tab_jou.Length;
        //do 
        //{
        //    StartCoroutine(dead());

        //}while(!tab_jou[0].GetComponent<PlayerHealthMult>().isDead /*|| !tab_jou[1].GetComponent<PlayerHealthMult>().isDead || !tab_jou[2].GetComponent<PlayerHealthMult>().isDead || !tab_jou[3].GetComponent<PlayerHealthMult>().isDead*/);

    
    //IEnumerator dead()
    //{
    //    yield return new WaitForSeconds(20);
        
    //}

}
