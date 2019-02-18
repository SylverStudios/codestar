using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StyledPromptDisplay : MonoBehaviour {

    public TextMeshPro textMeshPro;


    public void SetText(string _typed, char _current, string _remaining)
    {
        string typed = "<#ffffff>" + _typed + "</color>";
        string current = "<#a8a8a8><u>" + _current + "</u>";

        textMeshPro.text = "> " + typed + current + _remaining;
        textMeshPro.fontSize = 10;
    }

    public void SetHistory(string allText, string output)
    {
        textMeshPro.text = "<#a8a8a8>> " + allText + "\n" + output;
        textMeshPro.fontSize = 8;
    }

    public void Remove(GameObject anInstanceOfMe)
    {
        Destroy(anInstanceOfMe);
    }

}
