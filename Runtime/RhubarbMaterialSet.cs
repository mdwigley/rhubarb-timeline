using UnityEngine;
#pragma warning disable 0649

namespace FriendlyMonster.RhubarbTimeline
{
    [CreateAssetMenu(menuName = "Rhubarb/Material Set")]
    public class RhubarbMaterialSet : ScriptableObject
    {
        [SerializeField] private Material A;
        [SerializeField] private Material B;
        [SerializeField] private Material C;
        [SerializeField] private Material D;
        [SerializeField] private Material E;
        [SerializeField] private Material F;
        [SerializeField] private Material G;
        [SerializeField] private Material H;
        [SerializeField] private Material X;

        public Material GetMaterial(MouthShape mouthShape)
        {
            switch (mouthShape)
            {
                case MouthShape.A:
                    return A;
                case MouthShape.B:
                    return B;
                case MouthShape.C:
                    return C;
                case MouthShape.D:
                    return D;
                case MouthShape.E:
                    return E;
                case MouthShape.F:
                    return F;
                case MouthShape.G:
                    return G;
                case MouthShape.H:
                    return H;
                case MouthShape.X:
                    return X;
            }

            return null;
        }
    }
}