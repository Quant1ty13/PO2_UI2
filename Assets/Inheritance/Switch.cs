using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interaction
{
    public void Interacted()
    {
        if (isInteracted)
        {
            //Move a platform
            //Change toolTips details
            isInteracted = false;
            DisplayToolTips();
        }
        else
        {
            //Move a platform
            //Change toolTips details
            isInteracted = true;
            DisplayToolTips();
        }
    }
}
