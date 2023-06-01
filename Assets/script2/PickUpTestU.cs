using UdonSharp;
using UnityEngine;

public class PickUpTestU : UdonSharpBehaviour
{
    public string dropStr = "Drop!";
    public string pickUpStr = "PickUp!";

    public override void OnDrop()
    {
        Debug.Log(dropStr);
    }

    public override void OnPickup()
    {
        Debug.Log(pickUpStr);
    }
}