
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MaterialChangeTest : UdonSharpBehaviour
{
    public MeshRenderer meshRenderer;
    public Material material;
    
    public override void Interact()
    {
        meshRenderer.material = material;
    }
}
