using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Chest : Interaction
{
    public void Interacted()
    {
        if (isInteracted)
        {
            //play close animation
            isInteracted = false;
        }
        else
        {
            //play open animation
            isInteracted = true;
            DropLoot();
        }

    }

    private void DropLoot()
    {
        DisplayToolTips();
    }
}
