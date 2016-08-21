using UnityEngine;
using System.Collections;
using System;

/**
 * Simple action which print on the console a text
 * 
 */
public class Act_Describe : AAction
{
    public override void Act(GameObject target)
    {
        print("Player is describing " + target);
        print(target.GetComponent<View>().view);
    }
}
