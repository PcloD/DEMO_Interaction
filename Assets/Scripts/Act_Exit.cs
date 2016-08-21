using UnityEngine;
using System.Collections;
using System;

/**
 * Quit the application
 * 
 */
public class Act_Exit : AAction
{
    public override void Act(GameObject target)
    {
        Application.Quit();
    }
}
