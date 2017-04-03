using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class toText : MonoBehaviour
{
    public InputField field;
    public Text textBox;
    public string sentence;
    public string old;
    public Button post;

    public void Start()
    {
        post.GetComponentInChildren<Text>().text = "Post";
    }

    public void CopyText()
    {
        old = textBox.text;
        sentence = field.text + "\n";
        old = sentence + old;



        textBox.text = old;
    }
}
