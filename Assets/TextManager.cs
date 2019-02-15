using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {

    public List<Text> texts;

    private bool hasActiveText;
    private Text activeText;

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

    public void TypeLetter (char letter)
    {
        if (hasActiveText)
        {
            if (activeText.GetNextLetter() == letter)
            {
                activeText.TypeLetter();
            }
            // check if letter was next
            // remove it from the word
        } else
        {
            foreach(Text text in texts)
            {
                if(text.GetNextLetter() == letter)
                {
                    activeText = text;
                    hasActiveText = true;
                    text.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveText && activeText.TextTyped())
        {
            hasActiveText = false;
            texts.Remove(activeText);
        }

    }
}
