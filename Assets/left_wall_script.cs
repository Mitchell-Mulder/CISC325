using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class left_wall_script : MonoBehaviour {

    string perm_text;
    string access_token = "EAACEdEose0cBAHPJwNyGZC8mPHpeDqRMgMbXneBGUuZC4ej38VAxOuNFbmKDqUyaBv9YQGUQ1HZBWsLA4D9eAToWAOr6gqN4vkZCq3ZA35qtMe1h5GkJ01wZAHZBQ6baqssrEa32iobZBGyqXudhgXXaqSfHDwJJPgLtFdOznNR7G1CANB6GdBzV3wOKo8ZBSqAYZD";
    public GameObject my_wall;

    // Use this for initialization
    void Start () {
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
                GetComponent<TextMesh>().text = "Welcome: " + f.name;
                Debug.Log("Welcome: " + f.name);
            }
        }
    }
}
