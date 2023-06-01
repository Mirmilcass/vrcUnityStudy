using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ObjectToggleTest : UdonSharpBehaviour
{
    public new GameObject gameObject;

    public override void Interact()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}