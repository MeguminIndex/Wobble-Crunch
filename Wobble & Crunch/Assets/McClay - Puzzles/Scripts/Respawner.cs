 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour {


    public GameObject spawn;
    public List<GameObject> Pubspawns;
    static public Transform[] spawns;
    static GameObject spawnpoint;
    public int spawn_num = 1;
    static public int num;

    public static List<GameObject> children;


    void Start()
    {
        children = spawn.GetChildren();
        spawns = spawn.GetComponentsInChildren<Transform>();
        Pubspawns = children;
    }       
    
    void Update()
    {
        num = spawn_num;
    }

    static public void Respawn(GameObject dead)
    {
        Rigidbody velocity = dead.GetComponent<Rigidbody>();
        velocity.velocity = new Vector3(0, 0, 0);
        dead.transform.position = children[num].transform.position;
    }
}

public static class HelperMethods
{
    public static List<GameObject> GetChildren(this GameObject go)
    {
        List<GameObject> children = new List<GameObject>();
        foreach (Transform tran in go.transform)
        {
            children.Add(tran.gameObject);
        }
        return children;
    }
}