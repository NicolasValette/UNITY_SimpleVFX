using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleVFX.UI
{
    public class ExpandBackground : MonoBehaviour
    {

        [SerializeField]
        private GameObject _background;
        [SerializeField]
        private float _multiplicator = 5f;
        [SerializeField]
        private float _duration = 1.5f;
        [SerializeField]
        private Button _button;

        private Vector3 _originalSize;
        private Vector3 _maxSize;
        // Start is called before the first frame update
        void Start()
        {
            _originalSize = transform.localScale;
            _maxSize = _originalSize * _multiplicator;

            _button.onClick.AddListener(Expand);
            _button.GetComponentInChildren<TMP_Text>().text = "Expand Background";
        }



        public void Expand()
        {
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(Retract);
            _button.GetComponentInChildren<TMP_Text>().text = "Retract Background";
            StartCoroutine(ChangeSize(_originalSize, _maxSize));
        }
        public void Retract()
        {
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(Expand);
            _button.GetComponentInChildren<TMP_Text>().text = "Expand Background";
            StartCoroutine(ChangeSize(_maxSize, _originalSize));
        }

        public IEnumerator ChangeSize(Vector3 startingScale, Vector3 endingScale)
        {
            float timer = 0f;
            while (timer < _duration)
            {
                _background.transform.localScale = Vector3.Lerp(startingScale, endingScale, timer);
                timer += Time.deltaTime;
                yield return null;
            }
            _background.transform.localScale = endingScale;
        }
        
    }
}
