using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour
{
    string registeredGameName = "Epit'S'Cape_TestServer*-/*";
    bool isRefreshing = false;
    float refreshingRequestLength = 3.0f;
    HostData[] hostdata;
    private GameObject[] spawners;
    GameObject spawn;


    private void StartServer()
    {
        Network.InitializeServer(4, 192168019, false);
        MasterServer.RegisterHost(registeredGameName, "Networking Test Game", "Test Implementation of Server Code");
    }



    private void SpawnPlayer()
    {
        Debug.Log("Spawning Player...");
        spawners = GameObject.FindGameObjectsWithTag("spawn");
        //Random random = new Random();
        if(Network.isClient)
        {
            spawn = spawners[1];
        }
        spawn = spawners[0];
        Network.Instantiate(Resources.Load("player"), spawn.transform.position, Quaternion.identity, 0);
    }

    void OnGUI()
    {
        if(Network.isServer)
        {
            GUILayout.Label("running as server");
        }
        else if(Network.isClient)
        {
            GUILayout.Label("running as client");
        }
        if(Network.isClient)
        {
            if(GUI.Button(new Rect(Screen.width/2-75f, 25f, 150f, 30f), "Spawn"))
            {
                SpawnPlayer();
            }
        }
        if (!Network.isClient && !Network.isServer)
        {
            if (GUI.Button(new Rect(25f, 25f, 150f, 30f), "Start New Server"))
            {
                StartServer();
            }
            if (GUI.Button(new Rect(25f, 65f, 150f, 30f), "Refresh Server List"))
            {
                StartCoroutine("RefreshHostList");
            }
            if (hostdata != null)
            {
                for (int i = 0; i < hostdata.Length; i++)
                {
                    if (GUI.Button(new Rect(Screen.width / 2, 65f + (30f * i), 300f, 30f), hostdata[i].gameName))
                    {
                        Network.Connect(hostdata[i]);
                    }
                }
            }
        }
    }
    public IEnumerator RefreshHostList()
    {
        Debug.Log("Is refreshing ...");
        MasterServer.RequestHostList(registeredGameName);
        float timeStarted = Time.time;
        float timeEnd = Time.time + refreshingRequestLength;
        while (Time.time < timeEnd)
        {
            hostdata = MasterServer.PollHostList();
            yield return new WaitForEndOfFrame();
        }
        if (hostdata == null || hostdata.Length == 0)
        {
            Debug.Log("No Server found");
        }
        else
        {
            Debug.Log(hostdata.Length + "have been found");
        }
    }

    void OnMasterServerEvent(MasterServerEvent masterServerEvent)
    {
        if (masterServerEvent == MasterServerEvent.RegistrationSucceeded)
        {
            Debug.Log("Registration succeeded");
        }
    }
    //Application.LoadLevel("Level");
    void OnServerInitialized()
    {
        Debug.Log("Server initialiazed");
        SpawnPlayer();
    }

    void OnPLayerDisconnected(NetworkPlayer player)
    {
        Debug.Log("Player disconned from: " + player.ipAddress + ":" + player.port);
        Network.RemoveRPCs(player);
        Network.DestroyPlayerObjects(player);
    }
    void OnApplicationQuit()
    {
        if (Network.isServer)
        {
            Network.Disconnect(200);
            MasterServer.UnregisterHost();
        }
        if(Network.isClient)
        {
            Network.Disconnect(200);
        }
    }
}
