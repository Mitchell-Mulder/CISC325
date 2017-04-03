using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class add : MonoBehaviour
{
    public Button button1;

    public void Start()
    {
        button1.GetComponentInChildren<Text>().text = "Add Friend";
    }

    public void addFriend()
    {
        button1.GetComponentInChildren<Text>().text = "Friends";
    }

}
