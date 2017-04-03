using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class searchMessenger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] friends = new string[] { "Mitchell Mulder", "Nathaniel Cheung", "Vincent Hung", "Leonard Ha" };
        for (int i = 0; i < friends.Length; i++)
        {
            PlayerPrefs.SetString(i.ToString(), friends[i]);
            print(friends[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void OnClick (BaseEventData arg0)
    {
        int i = 0;
        GetComponent<TextMesh>().text += "\n";
        EventTrigger trigger = GetComponentInParent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener(OnReset);
        trigger.triggers.Add(entry);

        transform.position += new Vector3(0f, -2f, 0f);
        BoxCollider box = GetComponent<BoxCollider>();
        box.center += new Vector3(0f, 1f, 0f);
        while (PlayerPrefs.HasKey(i.ToString()))
        {
            GetComponent<TextMesh>().text += PlayerPrefs.GetString(i.ToString()) + "\n";
            i++;
        }
    }

    private void OnReset(BaseEventData arg0)
    {
        EventTrigger trigger = GetComponentInParent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener(OnClick);
        trigger.triggers.Add(entry);
        GetComponent<TextMesh>().text = "Search Messenger";

        transform.position += new Vector3(0f, 2f, 0f);
        BoxCollider box = GetComponent<BoxCollider>();
        box.center += new Vector3(0f, -1f, 0f);
    }
}
