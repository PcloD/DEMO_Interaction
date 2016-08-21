using UnityEngine;
using System.Collections;

/**
 * The Action class give capabilities to the character
 * 
 */
public abstract class AAction : MonoBehaviour {

    // The pawn represent the character who "own" the action
    protected InteractionPawn pawn;
    // List of decorator (condition) associated with this action
    ADecorator[] decorators;

    /**
     * We initialize our function
     * 
     */
    protected void Start()
    {
        pawn = GetComponentInParent<InteractionPawn>();
        decorators = GetComponents<ADecorator>();
    }

    /**
     * Each action has a certain number of decorator, if even one of them fail, the action can't be done.
     * 
     */
    public bool Try(GameObject target)
    {
        foreach (ADecorator decorator in decorators)
        {
            if (decorator.Try(transform.root.gameObject, target) == false)
                return false;
        }
        return true;
    }

    /**
     * Main function of the action, if the Try is a success, this function is called.
     * 
     */
    public abstract void Act(GameObject target);
}
