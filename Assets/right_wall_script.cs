using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_wall_script : MonoBehaviour {
    float counter = 0;
    int numbers = 0;
    string access_token = "EAACEdEose0cBAHPJwNyGZC8mPHpeDqRMgMbXneBGUuZC4ej38VAxOuNFbmKDqUyaBv9YQGUQ1HZBWsLA4D9eAToWAOr6gqN4vkZCq3ZA35qtMe1h5GkJ01wZAHZBQ6baqssrEa32iobZBGyqXudhgXXaqSfHDwJJPgLtFdOznNR7G1CANB6GdBzV3wOKo8ZBSqAYZD";

    public GameObject my_wall;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
        if (counter >= 1.0)
        {
            counter = 0;
            GetComponent<TextMesh>().text = "You have been living in a simulation for:\n" + numbers++.ToString() + " seconds";

            //GetComponent<TextMesh>().text = perm_text + Random.Range(0, 1000).ToString();
        }
    }
}
