using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

namespace SimpleVFX.Effect
{
    /// <summary>
    /// A Simple class to make a link with the volume of the post processing. With that, i can change volume parameter in runtime.
    /// </summary>
    public class EnableBloom : MonoBehaviour
    {
        [SerializeField]
        private Volume _volume;
        [SerializeField]
        private float _intensity;
        [SerializeField]
        private float _threshold;

        public float Intensity
        {
            get => _intensity;
            set
            {
                _intensity = value;
                _bloom.intensity.value = _intensity;
            }
        }
        public float Treshold
        {
            get => _threshold;
            set
            {
                _threshold = value;
                _bloom.threshold.value = _threshold;
            }
        }
        

        private Bloom _bloom;

        void Awake()
        {
            if (!_volume.profile.TryGet(out _bloom))
            {
                Debug.LogError("Missing BloomEffect");
            }
            _bloom.intensity.value = _intensity;
            _bloom.threshold.value = _threshold;
            _bloom.active = false;
        }

    
        public void ToggleBloom()
        {
            _bloom.intensity.value = _intensity;
            _bloom.threshold.value = _threshold;
            _bloom.active = !_bloom.active;
        }
    }
}
