using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
 * Here is the main focus of the demo, this component will handle each interaction.
 * 
 */
public class InteractionComponent : MonoBehaviour {

    // All the action the player can do
    List<AAction> actions = new List<AAction>();
    // The gameObjects close to the player
    List<GameObject> proximityTargets = new List<GameObject>();

    /**
     * For starter we get all the action of the character. 
     */
	void Start ()
    {
	    foreach (AAction action in GetComponentsInChildren<AAction>())
        {
            actions.Add(action);
        }
	}

    /**
     * Main function to deal with interaction
     * 
     */
    public void ProximityInteraction()
    {
        // First we select the closest target in the proximityTargets list
        GameObject target = GetClosestTarget();
        if (target == null)
            return;
        // Then we try to find a suitable action for this target
        AAction suitableAction = GetSuitableAction(target);
        if (suitableAction == null)
            return;
        // If there is indeed a suitable action, we act
        suitableAction.Act(target);
    }

    /**
     * We iterate through our action list in order to find suitable action.
     * 
     * In this demo, I didn't implement multiple action as it is not the focus there, 
     * but in case there is multiple suitable action, a choice should be asked of the player
     */
    AAction GetSuitableAction(GameObject target)
    {
        foreach (AAction action in actions)
        {
            if (action.Try(target) == true)
            {
                return action;
            }
        }
        return null;
    }

    /**
     * The case doesn't present itself on the demo level, but in case there is multiple object close, we take the closest one.
     * 
     */
    GameObject GetClosestTarget()
    {
        if (proximityTargets.Count <= 0)
            return null;                
        GameObject closestGameObject = proximityTargets[0];
        if (proximityTargets.Count > 1)
        {
            foreach (GameObject target in proximityTargets)
            {
                if (Vector2.Distance(transform.root.transform.position, target.transform.position) < Vector2.Distance(transform.root.transform.position, closestGameObject.transform.position))
                {
                    closestGameObject = target;
                }
            }
        }
        return closestGameObject;
    }

    /**
     * The two following function manage the list of targets.
     * 
     */

    public void AddProximityTarget(GameObject newTarget)
    {
        if (proximityTargets.Contains(newTarget))
            return;
        proximityTargets.Add(newTarget);
    }

    public void RemoveProximityTarget(GameObject targetToRemove)
    {
        proximityTargets.Remove(targetToRemove);
    }
}
