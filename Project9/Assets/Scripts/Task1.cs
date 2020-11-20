using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello world!");
        Debug.Log("test debug log");
        Debug.LogError("Error");
        Debug.LogWarning("Warning");
    }

    // Update is called once per frame
    void Update()
    {
        print("Test update function");
    }
}
