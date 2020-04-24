using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using Valve.VR.InteractionSystem;

public class SpawnPoints : MonoBehaviour
{
    //Shuan - setting up multiple spawn poins.
    public GameObject[] SpawnLocation;
    public GameObject player;
    public Vector3 RespawnLocation;

    /*
    //Ethan - Work in progress
    public Transform[] SpawnLoc;
    */

    public void Awake()
    {
        // Look for the empties with the spawn tags on them
        SpawnLocation = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }
    void Start()
    {
        player = (GameObject)Resources.Load("player2," , typeof(GameObject));

        RespawnLocation = player.transform.position;

        SpawnPlayer();
    }
    public void SpawnPlayer()
    {
        int spawn = Random.Range(0, SpawnLocation.Length);
        GameObject.Instantiate(player, SpawnLocation[spawn].transform.position, Quaternion.identity);
    }
}
