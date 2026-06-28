using UnityEngine;
using TMPro;
using MDAY2026.FoodConditions;
using MDAY2026.SoundEffects;

namespace MDAY2026.FoodCreation
{
    public class FoodCreationManager : MonoBehaviour
    {
        #region Variables

        [Header("Variables")]

        [Space(5)]

        [SerializeField] private GameObject _resultsScreen;

        [SerializeField] private float _resultsScreenDisplayDelayAmount;

        private Timer _resultsScreenDisplayDelayTimer;

        private bool _displayingResults;

        [Header("Canvas Components")]

        [Space(5)]

        [SerializeField] private TextMeshProUGUI _resultsText;

        [Header("Scripts")]

        [Space(5)]

        [SerializeField] private FoodConditionChecker _foodConditionChecker;

        [SerializeField] private FoodSoundPlayer _foodSoundPlayer;

        #endregion

        #region Methods

        public void CallDisplayResults()
        {
            _resultsScreenDisplayDelayTimer.Restart();
            _displayingResults = true;
        }

        private void DisplayResults()
        {
            if (_resultsScreenDisplayDelayTimer.HasExpired == true && _displayingResults == true)
            {
                // Get final grade for food here from FoodConditionChecker
                float grade = _foodConditionChecker.GetGrade();
                _resultsText.text = grade.ToString() + "/5 stars";

                // Play the appropriote SFX for poor or good grade
                if (grade < 3)
                {
                    _foodSoundPlayer.PlaySFXClipAt("RatingBad", transform.position, 1, false);
                }
                else
                {
                    _foodSoundPlayer.PlaySFXClipAt("RatingGood", transform.position, 1, false);
                }

                _resultsScreen.SetActive(true);

                _displayingResults = false;
            }
        }

        private void InitialiseTimer()
        {
            _resultsScreen.SetActive(false);

            _resultsScreenDisplayDelayTimer.Duration = _resultsScreenDisplayDelayAmount;
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
            DisplayResults();
        }

        #endregion
    }
}