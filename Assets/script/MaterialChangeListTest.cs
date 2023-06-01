using UdonSharp;
using UnityEngine;

namespace script
{
    public class MaterialChangeListTest : UdonSharpBehaviour
    {
        public Material[] materials;
        public MeshRenderer mr;
        private int _count;

        public override void Interact()
        {
            if (_count == materials.Length) _count = 0;
            mr.material = materials[_count++];
        }
    }
}