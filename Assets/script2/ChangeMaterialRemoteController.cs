using UdonSharp;
using UnityEngine;

namespace script2
{
    public class ChangeMaterialRemoteController : UdonSharpBehaviour
    {
        public GameObject target;
        private Material[] _materials;
        private int _count;

        public override void OnPickupUseDown()
        {
            /* 지정 객체에 작성되어 있는 Udon 스크립트 정보를 가져온다. */
            var targetUdon = target.GetComponent<UdonSharpBehaviour>();
            /* 스크립트 정보 안에 저장된 변수에 접근 materials 데이터 획득 */
            var programVariable = targetUdon.GetProgramVariable("materials");
            /* 빈값 확인 */
            if (programVariable == null) return;
            /* U#에서 제공해주는 다른 편의성 기능들을 사용 불가 형변환만 적용 가능 */
            _materials = (Material[])programVariable;
            if (_count == _materials.Length) _count = 0;
            Debug.Log("PickUpUseDown!!! :: Count : " + _count);
            var meshRenderer = target.GetComponent<MeshRenderer>();
            meshRenderer.material = _materials[_count++];
        }

        public override void OnPickup()
        {
            Debug.Log("PickUP!!!");
        }

        public override void OnDrop()
        {
            Debug.Log("Drop!!!!");
        }
    }
}