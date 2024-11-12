using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interaction
{
    public override void Interacted()
    {
        base.Interacted();
        if (isInteracted)
        {
            //Move a platform
            //Change toolTips details
            DisplayToolTips();
        }
        else
        {
            //Move a platform
            //Change toolTips details
            DisplayToolTips();
        }
    }
}
