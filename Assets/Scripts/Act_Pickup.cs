using UnityEngine;
using System.Collections;
using System;

/**
 * Represent the action of picking up object.
 * 
 * It is simplified for this demo, has it just set the pawn bKey at true.
 * 
 */
public class Act_Pickup : AAction
{
    public override void Act(GameObject target)
    {
        print("Player is pickingUp the key " + target);
        pawn.bKey = true;
        // Once the interaction done, we remove from the proximityTarget list this object and then destroy it
        pawn.Interaction.RemoveProximityTarget(target);
        Destroy(target);
    }
}
