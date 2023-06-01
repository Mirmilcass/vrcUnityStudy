using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ObjectMoveTest : UdonSharpBehaviour
{
    public GameObject targetObject;
    public Transform targetInfo;

    public override void Interact()
    {
        targetObject.transform.SetPositionAndRotation(targetInfo.position, targetInfo.rotation);
    }
}