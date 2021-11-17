using UnityEngine;

namespace Gameplay
{
    public class WeightComponent : MonoBehaviour
    {
        public int Weight { get; private set; }

        public void InitStartWeight(int startWeight)
        {
            Weight = startWeight;
        }

        public void UpdateWeight(int weightToAdd)
        {
            Weight = Mathf.Clamp(Weight + weightToAdd, Constants.MinWeight, Constants.MaxWeight);
        }
    }
}
