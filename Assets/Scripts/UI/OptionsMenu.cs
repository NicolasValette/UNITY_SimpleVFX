using UnityEngine;
using UnityEngine.UI;

namespace SimpleVFX.UI
{
    public class OptionsMenu : MonoBehaviour
    {
        [Header("Shake Panel")]
        [SerializeField]
        private Button _shakeButton;
        [SerializeField]
        private GameObject _shakeMenu;
        [SerializeField]
        private ShakeOptions _shakeOption;
        [Header("Bloom Panel")]
        [SerializeField]
        private Button _bloomButton;
        [SerializeField]
        private GameObject _bloomMenu;
        [SerializeField]
        private BloomOptions _bloomOption;
        [Header("Effect Panel")]
        [SerializeField]
        private Button _effectButton;
        [SerializeField]
        private GameObject _effectMenu;

        // Start is called before the first frame update
        void Start()
        {
            DisplayShakePanel();
        }

        public void DisplayShakePanel()
        {
            _shakeButton.interactable = false;
            _bloomButton.interactable = true;
            _effectButton.interactable = true;

            _shakeMenu.SetActive(true);
            _bloomMenu.SetActive(false);
            _effectMenu.SetActive(false);

            _shakeOption.UpdateValues();
        }
        public void DisplayBloomPanel()
        {
            _shakeButton.interactable = true;
            _bloomButton.interactable = false;
            _effectButton.interactable = true;

            _shakeMenu.SetActive(false);
            _bloomMenu.SetActive(true);
            _effectMenu.SetActive(false);

            _bloomOption.UpdateValues();
        }
        public void DisplayEffectPanel()
        {
            _shakeButton.interactable = true;
            _bloomButton.interactable = true;
            _effectButton.interactable = false;

            _shakeMenu.SetActive(false);
            _bloomMenu.SetActive(false);
            _effectMenu.SetActive(true);

        }
    }
}
