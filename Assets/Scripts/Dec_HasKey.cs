using UnityEngine;
using System.Collections;
using System;

/**
 * Slightly more complex decorator, it check the condition of both the actor and the target
 * 
 */
public class Dec_HasKey : ADecorator
{
    /**
     * For this decorator we are comparing both the actor and the target
     * 
     */
    public override bool Try(GameObject actor, GameObject target)
    {
        if (target.GetComponent<Door>().bNeedKey == false)
            return true;
        if (actor.GetComponent<InteractionPawn>() == null)
            return false;
        if (actor.GetComponent<InteractionPawn>().bKey == false)
            return false;
        return true;
    }
}
