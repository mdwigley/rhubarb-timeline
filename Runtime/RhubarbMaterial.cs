using UnityEngine;

namespace FriendlyMonster.RhubarbTimeline
{
    [RequireComponent(typeof(MeshRenderer))]
    public class RhubarbMaterial : RhubarbClipBase
    {
        private MeshRenderer _meshRenderer;
        [SerializeField] private RhubarbMaterialSet _rhubarbMaterialSet;

        public RhubarbMaterialSet RhubarbSpriteSet
        {
            get { return _rhubarbMaterialSet; }
            set { _rhubarbMaterialSet = value; }
        }

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public override MouthShape MouthShape
        {
            set
            {
                if (_meshRenderer == null)
                {
                    _meshRenderer = GetComponent<MeshRenderer>();
                }

                _meshRenderer.sharedMaterial = _rhubarbMaterialSet.GetMaterial(value);
            }
        }

    }
}