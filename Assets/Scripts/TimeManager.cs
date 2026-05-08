using TMPro;
using UnityEngine;

namespace MDAY2026.TimeLimit
{
    public class TimeManager : MonoBehaviour
    {
        #region Variables

        [Header("Variables")]

        [Space(5)]

        private float _elapsedTime;

        [SerializeField] private float _timeLimitStartingAmount;

        [SerializeField] private float _timeLimitCurrentAmount;

        private bool _timeRunning = true;

        [Header("Canvas Elements")]

        [Space(5)]

        [SerializeField] private TextMeshProUGUI _timeLimitText;

        #endregion

        #region Methods

        private void UpdateTimer()
        {
            if (_timeRunning == true)
            {
                _elapsedTime += Time.deltaTime;

                if (_elapsedTime >= 1)
                {
                    _timeLimitCurrentAmount--;
                    _elapsedTime = 0;

                    UpdateTimeLimit();
                    CheckForTimeEnd();
                }
            }
        }

        private void UpdateTimeLimit()
        {
            _timeLimitText.text = _timeLimitCurrentAmount.ToString();
        }

        private void CheckForTimeEnd()
        {
            if (_timeLimitCurrentAmount <= 0)
            {
                Debug.Log("Time over!");
                _timeRunning = false;
                GameManager.instance.EndGame();
            }
        }

        public void StopTimer()
        {
            _timeRunning = false;
        }

        private void InitialiseTimer()
        {
            _timeLimitCurrentAmount = _timeLimitStartingAmount;
            _timeLimitText.text = _timeLimitCurrentAmount.ToString();

            _timeRunning = true;
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            InitialiseTimer();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateTimer();
        }

        #endregion
    }
}