using UdonSharp;
using UnityEngine;

public class RecallObject : UdonSharpBehaviour
{
    public GameObject target;
    public Transform respawnLocation;

    public override void Interact()
    {
        target.transform.SetPositionAndRotation(respawnLocation.position, respawnLocation.rotation);
        target.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}