using UnityEngine;

namespace MDAY2026.FoodCreation
{
    public class FoodParenter : MonoBehaviour
    {
        #region Variables

        [Header("Variables")]

        [Space(5)]

        [SerializeField] private Transform _objectToParentTo;

        #endregion

        #region Methods

        private void ParentObject(Transform objectToParent)
        {
            if (objectToParent.gameObject.CompareTag("Food") && objectToParent.parent != _objectToParentTo)
            {
                objectToParent.parent = _objectToParentTo;
            }
        }

        private void UnparentObject(Transform objectToParent)
        {
            if (objectToParent.gameObject.CompareTag("Food") && objectToParent.parent == _objectToParentTo)
            {
                objectToParent.parent = null;
            }
        }

        #endregion

        #region Unity Methods

        private void OnTriggerEnter(Collider other)
        {
            ParentObject(other.gameObject.transform);
        }

        private void OnTriggerExit(Collider other)
        {
            UnparentObject(other.gameObject.transform);
        }

        #endregion
    }
}