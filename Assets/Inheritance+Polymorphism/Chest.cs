using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Chest : Interaction
{
    public override void Interacted()
    {
        base.Interacted();
        if (isInteracted)
        {
            //play close animation
        }
        else
        {
            //play open animation
            DropLoot();
        }

    }

    private void DropLoot()
    {
        DisplayToolTips();
    }
}
