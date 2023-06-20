using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingSpot : MonoBehaviour
{
    public Transform PlayerObject;

    public void DoTeleport()
    {
        //Set the player object position to match this object's position.
        PlayerObject.position = transform.position;
    }
}
