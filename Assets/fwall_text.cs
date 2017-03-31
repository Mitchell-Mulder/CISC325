using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class fwall_text : MonoBehaviour
{

    string perm_text;
    string access_token = "EAACEdEose0cBAHPJwNyGZC8mPHpeDqRMgMbXneBGUuZC4ej38VAxOuNFbmKDqUyaBv9YQGUQ1HZBWsLA4D9eAToWAOr6gqN4vkZCq3ZA35qtMe1h5GkJ01wZAHZBQ6baqssrEa32iobZBGyqXudhgXXaqSfHDwJJPgLtFdOznNR7G1CANB6GdBzV3wOKo8ZBSqAYZD";
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
