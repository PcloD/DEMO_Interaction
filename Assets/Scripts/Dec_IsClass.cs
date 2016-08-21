using UnityEngine;
using System.Collections;

/**
 * This decorator maker sure that the target (or the actor) is of class : className
 * 
 */
public class Dec_IsClass : ADecorator {

    public string className;

    public override bool Try(GameObject actor, GameObject target)
    {
        GameObject finaltarget = target;
        if (bDecorateSelf)
            finaltarget = actor;
        
        if (finaltarget.GetComponent(className) == null)
            return false;
        return true;
    }
}
