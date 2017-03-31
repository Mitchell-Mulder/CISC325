using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class fwall_text : MonoBehaviour {
    
    string perm_text;
    string access_token = "EAACEdEose0cBAHPJwNyGZC8mPHpeDqRMgMbXneBGUuZC4ej38VAxOuNFbmKDqUyaBv9YQGUQ1HZBWsLA4D9eAToWAOr6gqN4vkZCq3ZA35qtMe1h5GkJ01wZAHZBQ6baqssrEa32iobZBGyqXudhgXXaqSfHDwJJPgLtFdOznNR7G1CANB6GdBzV3wOKo8ZBSqAYZD";
    public GameObject my_wall;

	// Use this for initialization
	void Start () {
        GetComponent<TextMesh>().text = "";
        StartCoroutine(GetText());
	}
	
	// Update is called once per frame
	void Update () {

	}
    IEnumerator GetText()
    {
        using (UnityWebRequest request = UnityWebRequest.Get("https://graph.facebook.com/v2.8/me?fields=id,name,cover&access_token=" + access_token))
        {
            yield return request.Send();

            if (request.isError) // Error
            {
                Debug.Log(request.error);
            }
            else // Success
            {
                Debug.Log(request.downloadHandler.text);
                fb_info f = JsonUtility.FromJson<fb_info>(request.downloadHandler.text);
                perm_text = f.name; //+ "\nCoverID: " + f.cover.id;
                Debug.Log(f.cover.source);
                StartCoroutine(GetTexture(f.cover.source));
            }
        }
    }
    IEnumerator GetTexture(string uri)
    {
        using (UnityWebRequest www = UnityWebRequest.GetTexture(uri))
        {
            yield return www.Send();

            if (www.isError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Trying to set the wall to my background");
                Texture myTexture = DownloadHandlerTexture.GetContent(www);
                Debug.Log(my_wall.GetComponent<Renderer>().material);
                my_wall.GetComponent<Renderer>().material.mainTexture = myTexture;
                my_wall.GetComponent<Renderer>().material.SetTexture(1, myTexture);
            }
        }
    }
}

[System.Serializable]
public class fb_info
{
    public string id;
    public string name;
    public cover_p cover;
}
[System.Serializable]
public class cover_p
{
    public string id;
    public int offset_y;
    public string source;
}
