using UnityEngine;

namespace Gameplay
{
    public class ScalesController : MonoBehaviour
    {
        private const int WeightScaler = 5;
        private const int WeightOffset = 10;

        public int TargetWeight { get; private set; }

        public void SetNewRandomTargetWeight()
        {
            //weight should be multiple of 5
            int min = Constants.MinWeight / WeightScaler;
            int max = Constants.MaxWeight / WeightScaler + 1;

            TargetWeight = Random.Range(min, max) * WeightScaler;
        }

        public WeighingResult GetWeighingResult(WeightComponent weightComponent)
        {
            int diffAbs = Mathf.Abs(TargetWeight - weightComponent.Weight);

            switch (diffAbs / WeightOffset)
            {
                case 0:
                    return WeighingResult.Perfect;
                case 1:
                    return WeighingResult.Nice;
                case 2:
                    return WeighingResult.Good;
                default:
                    return WeighingResult.Missed;
            }
        }
    }
}
