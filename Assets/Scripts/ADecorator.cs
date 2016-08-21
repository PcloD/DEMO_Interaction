using UnityEngine;
using System.Collections;

/**
 * The decorator is basicaly a "if" in a script form. The name is taken from the behaviour tree's decorator.
 * 
 */
public abstract class ADecorator : MonoBehaviour {

    // Is the decorator condition should be checked on the actor, or the target?
    public bool bDecorateSelf;

    // Each Decorator children has to implement its own Try function.
    public abstract bool Try(GameObject actor, GameObject target);
}
