using UnityEngine;

namespace SimpleVFX.Effect
{
    public class RunParticleEffect : MonoBehaviour
    {
        [Tooltip("The particle system to run")]
        [SerializeField]
        private ParticleSystem _particleSystem;
        
        public void RunEffect()
        {
            if (_particleSystem.isPlaying)
                _particleSystem.Stop();

            _particleSystem.Play();
        }
    }
}
