using UnityEngine;
using System.Collections;

/**
 * This object has a invisible block as a children which block the character.
 * 
 */
public class Door : MonoBehaviour {

    // If true, a key is needed to pass through this door
    public bool bNeedKey;

    // Block which, well, block the player
    public GameObject block;

    /**
     * Disable the block, allowing free passage for the player
     * 
     */
    public void Open()
    {
        block.SetActive(false);
    }
}
