using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGenerator : MonoBehaviour {

    private static string[] textList = { "git status", "git rebase --abort", "rm -rf /", "git add .", "git commit -m \"DO NOT MERGE\"" };

    public static string GetRandomText () {

        int randomIndex = Random.Range(0, textList.Length);

        string randomText = textList[randomIndex];

        return randomText;
    }
}
