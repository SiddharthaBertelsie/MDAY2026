using MDAY2026.ItemGrabber;
using UnityEngine;
using System.Collections.Generic;

namespace MDAY2026.FoodCreation
{
    public class FoodParenter : MonoBehaviour
    {
        #region Variables

        [Header("Variables")]

        [Space(5)]

        [SerializeField] private Transform _objectToParentTo;

        [SerializeField] private List<Item> _parentedItems = new List<Item>();
        public List<Item> ParentedItems {  get { return _parentedItems; } }

        #endregion

        #region Methods

        private void ParentObject(Transform objectToParent)
        {
            if (objectToParent.gameObject.CompareTag("Food") && objectToParent.parent != _objectToParentTo)
            {
                objectToParent.parent = _objectToParentTo;

                if (objectToParent.GetComponent<Item>() != null)
                {
                    _parentedItems.Add(objectToParent.GetComponent<Item>()); // Add to list so we can check if current items on plate meet conditions
                }
            }
        }

        private void UnparentObject(Transform objectToParent)
        {
            if (objectToParent.gameObject.CompareTag("Food") && objectToParent.parent == _objectToParentTo)
            {
                objectToParent.parent = null;

                if (objectToParent.GetComponent<Item>() != null)
                {
                    _parentedItems.Remove(objectToParent.GetComponent<Item>());
                }
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