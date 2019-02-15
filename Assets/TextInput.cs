﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextInput : MonoBehaviour {

    public TextManager textManager;

	
	// Update is called once per frame
	void Update () {
        foreach (char letter in Input.inputString) {
            Debug.Log(letter);
            textManager.TypeLetter(letter);
        }
	}
}
