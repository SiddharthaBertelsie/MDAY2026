using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MDAY2026.ItemGrabber
{
    public class Item : MonoBehaviour
    {
        #region Variables

        [Header("Variables")]

        [Space(5)]

        private bool _hasBeenSelected = false;
        public bool HasBeenSelected {  get { return _hasBeenSelected; } set { _hasBeenSelected = value; } }

        [Header("Components")]

        [Space(5)]

        [SerializeField] private Rigidbody _rigidbody;

        #endregion

        #region Methods

        public void OnMouseDown()
        {
            switch (_hasBeenSelected)
            {
                case true:
                    Debug.Log("Dropping item");
                    _hasBeenSelected = false;
                    break;
                case false:
                    Debug.Log("We've selected the item!");
                    _hasBeenSelected = true;
                    _rigidbody.linearVelocity = Vector3.zero; // Do this as obj will fall faster and faster each time it is dropped and selected
                    break;
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