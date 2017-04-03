using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class likes : MonoBehaviour {
    public int number = 0;
    public Text likeBox;

    public void liked()
    {
        number += 1;
        likeBox.text = number + "Likes";
    }
}
