using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallerScripts : MonoBehaviour
{
    [SerializeField] private Chest chest;
    [SerializeField] private Switch newSwitch;
    void Start()
    {
        chest.Interacted();
        newSwitch.Interacted();
    }
}
