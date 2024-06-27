using SimpleVFX.Effect;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleVFX.UI
{
    public class BloomOptions : MonoBehaviour
    {
        [SerializeField]
        private EnableBloom _bloomComponant;
        [SerializeField]
        private Slider _bloomThresholdSlider;
        [SerializeField]
        private Slider _bloomIntensitySlider;
        
        // Start is called before the first frame update
        void Start()
        {
            UpdateValues();
        }

       public void UpdateValues()
        {
            _bloomThresholdSlider.value = _bloomComponant.Treshold;
            _bloomIntensitySlider.value = _bloomComponant.Intensity;
        }
    }
}
