using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class fwall_text : MonoBehaviour
{

    string perm_text;
    public GameObject my_wall;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveUp()
    {
        transform.position += new Vector3(0f, 1f, 0f);
        print("hello");
    }
}
