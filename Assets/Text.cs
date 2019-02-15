using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Text {

    public string text;
    private int typeIndex;

    public Text (string _text)
    {
        text = _text;
        typeIndex = 0;
    }

    public char GetNextLetter ()
    {
        return text[typeIndex];
    }

    public void TypeLetter (){
        typeIndex++;
        // remove letter from the screen

    }

    public bool TextTyped ()
    {
        bool textTyped = (typeIndex >= text.Length);
        if (textTyped)
        {
            // remove text on screen
        }
        return textTyped;
    }


}
