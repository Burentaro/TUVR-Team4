using UnityEngine;
using System.Collections;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Remote : MonoBehaviour
{
	public SteamVR_Action_Boolean angleAction;
	public Hand hand;



    public Cannon cannon;           // Reference to the Cannon
    private bool isHeld = false;    // A flag that we user to know if the remote is being held by the player
    
    /// <summary>
    /// A simple toggle method to set whether the remote is being held or not. 
    /// Attach this to the SteamVR Throwable component.
    /// </summary>
    public void HoldRemote()
    {
        bool oldHoldValue = isHeld;
        if (oldHoldValue)
        {
            isHeld = false;
        }
        else
        {
            isHeld = true;
        }
    }

    public void Fire()
    {
        // TO-DO!!
        // Create script to only call the Shoot method on the cannon if remote is held
    }

    public void IncreaseAngle()
    {
        // TO-DO!!
        // Create script to only call the AddCannonAngle method on the cannon if remote is held
    }

    public void DecreaseAngle()
    {
        // TO-DO!!
        // Create script to only call the AddCannonAngle method on the cannon if remote is held
    }
}
