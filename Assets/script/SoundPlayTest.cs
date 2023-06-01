using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SoundPlayTest : UdonSharpBehaviour
{
    public AudioSource audioSource;

    public override void Interact()
    {
        audioSource.Play();
    }
}