using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Prompt {

    public string text;

    [SerializeField]
    private char currentChar;

    [SerializeField]
    private string textTyped, textRemaining;

    [SerializeField]
    private bool complete;

    private StyledPromptDisplay styled;
    private GameObject promptPreFab;

    public Prompt(string _text, GameObject _promptPreFab)
    {
        text = _text;
        promptPreFab = _promptPreFab;
        styled = promptPreFab.GetComponent<StyledPromptDisplay>();

        textTyped = "";
        currentChar = _text[0];
        textRemaining = _text.Substring(1);
        complete = false;

        UpdateDisplay();
    }

    public char GetNextLetter ()
    {
        return currentChar;
    }


    // move current char into typed, move front of remaining to current
    public void TypeLetter (){
        textTyped = textTyped + currentChar;

        // Do I need to catch this is the remaining is blank?
        if (textRemaining.Length == 0)
        {
            textRemaining = "";
            complete = true;
        } else
        {
            currentChar = textRemaining[0];
            textRemaining = textRemaining.Substring(1);
        }

        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        if (complete)
        {
            float previousY = promptPreFab.transform.position.y;
            float newY = previousY + 2.0f;

            Vector3 pos = promptPreFab.transform.position;
            pos.y = pos.y + 2.0f;
            promptPreFab.transform.position = pos;

           
            styled.SetHistory(text, "output would go here");
        } else
        {
            styled.SetText(textTyped, currentChar, textRemaining);
        }
    }

    public bool TextTyped ()
    {
        if (complete) {
            // move to history
        }
        return complete;
    }

    public string Typed ()
    {
        return textTyped;
    }

    public string Remaining ()
    {
        return currentChar + textRemaining;
    }

    public void Remove()
    {
        styled.Remove(promptPreFab);
    }


}
