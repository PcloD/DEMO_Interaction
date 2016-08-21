using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
 * This class will hold all the piece of the character together, the movement component, interaction, combat, inventory, etc...
 * 
 * For this demo, it is simplified to the minimum
 * 
 */
public class InteractionPawn : MonoBehaviour {

    // This is the interaction Component (and its getter/setter)
    InteractionComponent interaction;
    public InteractionComponent Interaction
    {
        get
        {
            return interaction;
        }

        set
        {
            interaction = value;
        }
    }

    // For this demo I will use a simple boolean to determine if the player has a key or not.
    public bool bKey;

    /*
     * During the Start, we gather the different component. I usually put my component in children of the pawn, (and then do a GetComponentInChildren)
     * but for this demo, the component will be directly with the pawn.
     */
    void Start()
    {
        interaction = GetComponent<InteractionComponent>();
    }
}
