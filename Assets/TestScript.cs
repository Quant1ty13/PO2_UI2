using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SampleNameSpace;

public class TestScript : MonoBehaviour
{
    private SampleScripts sampleScripts;

    private string newUsername;

    private void Start()
    {
        sampleScripts = GetComponent<SampleScripts>();
    }
    private void OnGUI()
    {
        newUsername = GUI.TextField(new Rect(10, 10, 100, 30), newUsername);

        if(GUI.Button(new Rect(50, 100, 100, 50), "Press ME!"))
        {
            sampleScripts.Username = newUsername;
            
        }
    }
}
