using SimpleVFX.Effect;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleVFX.UI
{
    public class ShakeOptions : MonoBehaviour
    {
        [SerializeField]
        private ShakeCamera _shakeCamera;
        [SerializeField]
        private Slider _shakeDurationSlider;
        [SerializeField]
        private Slider _shakeSmoothnessSlider;
        [SerializeField]
        private TMP_InputField _shakeStrengthInputField;

        // Start is called before the first frame update
        void Start()
        {
            UpdateValues();
        }

 
        public void UpdateValues()
        {
            _shakeDurationSlider.value = _shakeCamera.ShakeDuration;
            _shakeSmoothnessSlider.value = _shakeCamera.ShakeSmoothness;
           _shakeStrengthInputField.text = _shakeCamera.ShakeStrengh.ToString();
           
        }
        public void SetShakeStrength(string inputStrength)
        {
            if (float.TryParse(inputStrength, out float value))
            {
                _shakeCamera.ShakeStrengh = value;
            }
        }
    }
}
