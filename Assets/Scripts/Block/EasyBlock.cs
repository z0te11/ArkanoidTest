using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyBlock : Block, IInteract
{
    public void InteractWithObject()
    {
        GetDamage();
    }
}
