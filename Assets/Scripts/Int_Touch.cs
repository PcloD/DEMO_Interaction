using UnityEngine;
using System.Collections;

/**
 * This script make the gameObject it is attached on "touchable", meaning it will be added in the proximityTargets list of whoever touch this object
 * 
 */
[RequireComponent(typeof(Collider2D))]
public class Int_Touch : MonoBehaviour {

    void Start()
    {
        // With this, we are making sure the collider is set as a trigger
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<InteractionComponent>())
        {
            col.gameObject.GetComponent<InteractionComponent>().AddProximityTarget(this.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<InteractionComponent>())
        {
            col.gameObject.GetComponent<InteractionComponent>().RemoveProximityTarget(this.gameObject);
        }
    }
}
