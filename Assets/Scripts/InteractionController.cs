using UnityEngine;
using System.Collections;

/**
 * This class register the user control and call the appropriate function.
 * 
 * For this demo, this class only take care of the interaction control.
 * 
 */
public class InteractionController : MonoBehaviour {

    // Every component is stored within interaction pawn, having acces to pawn give access to all the other components
    InteractionPawn pawn;

    void Start()
    {
        pawn = GetComponent<InteractionPawn>();
    }

    /**
     * Every time the 'Use' button is pushed, the ProximityFunction is launched.
     * 
     * I use ProximityInteraction because in my main project there is also DistanceInteraction which use the click of the mouse.
     * 
     */
	void Update ()
    {
        if (Input.GetButtonDown("Use"))
        {
            pawn.Interaction.ProximityInteraction();
        }
	}
}
