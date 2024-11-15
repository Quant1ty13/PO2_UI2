using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] protected string toolTips;
    [SerializeField] protected bool isInteracted;

    protected void DisplayToolTips()
    {
        Debug.Log("Tool Tips: " + toolTips);
    }

    public virtual void Interacted()
    {
        if (isInteracted)
        {
            isInteracted = false;
        }
        else
        {
            isInteracted= true;
        }
    }
}
