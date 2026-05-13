using UnityEngine;

namespace MDAY2026.RepeatedRounds
{
    public class StatHandler : MonoBehaviour
    {
        #region Static Declaration

        public static StatHandler instance;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        #endregion

        #region Variables

        public static int roundsCompleted = 0;

        #endregion
    }
}