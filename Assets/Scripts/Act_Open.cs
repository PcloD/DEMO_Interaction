using UnityEngine;
using System.Collections;
using System;

/**
 * Open the door.
 * 
 * Once again simplified, but for a more efficient use, a script "Openable" should be used, and put on every "openable" object.
 * 
 */
public class Act_Open : AAction
{
    public override void Act(GameObject target)
    {
        target.GetComponent<Door>().Open();
    }
}
