using GJAM5.SoundEffects;
using UnityEngine;

namespace MDAY2026.SoundEffects
{
    public class FoodSoundPlayer : SoundPlayer
    {
        #region Methods

        public override AudioClip GetSFX(string soundEffect)
        {
            switch (soundEffect)
            {
                case "ItemSpawned":
                    return _soundEffects[0];
                case "ItemGrabbed":
                    return _soundEffects[1];
                case "RatingBad":
                    return _soundEffects[2];
                case "RatingGood":
                    return _soundEffects[3];
                default:
                    return null;
            }
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion
    }
}