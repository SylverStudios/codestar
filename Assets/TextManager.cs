using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {

    public List<Text> texts;

    private void Start()
    {
        AddText();
        AddText();
        AddText();
    }

    public void AddText() {
        Text text = new Text(TextGenerator.GetRandomText());
        Debug.Log(text.text);

        texts.Add(text);
    }
}
