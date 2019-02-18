using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyledPromptSpawner : MonoBehaviour {

    public GameObject styledDisplayPrefab;

    public GameObject Spawn()
    {
        Vector3 promptLine = new Vector3(4.5f,-5.75f,0f);

        GameObject prefab = Instantiate(styledDisplayPrefab, promptLine, Quaternion.identity);

        return prefab;
    }

}
