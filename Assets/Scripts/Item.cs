using MDAY2026.SoundEffects;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MDAY2026.ItemGrabber
{
    public class Item : MonoBehaviour
    {
        #region Variables

        [Header("Parameters")]

        [Space(5)]

        [SerializeField] private string _itemName;
        public string ItemName { get { return _itemName; } set { _itemName = value; } }

        [SerializeField] private string _itemType;
        public string ItemType { get { return _itemType; } set { _itemType = value; } }

        [Header("Variables")]

        [Space(5)]

        [SerializeField] private bool _hasBeenSelected = false;
        public bool HasBeenSelected { get { return _hasBeenSelected; } set { _hasBeenSelected = value; } }

        [Header("Components")]

        [Space(5)]

        [SerializeField] private Rigidbody _rigidbody;

        [Header("Scripts")]

        [Space(5)]

        [SerializeField] private FoodSoundPlayer _foodSoundPlayer;

        #endregion

        #region Methods

        public void OnMouseDown()
        {
            switch (_hasBeenSelected)
            {
                case true:
                    Debug.Log("Dropping item");
                    _foodSoundPlayer.PlaySFXClipAt("ItemGrabbed", transform.position, 1, false);
                    _hasBeenSelected = false;
                    break;
                case false:
                    Debug.Log("We've selected the item!");
                    _hasBeenSelected = true;
                    _rigidbody.linearVelocity = Vector3.zero; // Do this as obj will fall faster and faster each time it is dropped and selected
                    _rigidbody.angularVelocity = Vector3.zero;
                    break;
            }
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _foodSoundPlayer = GameObject.FindGameObjectWithTag("SoundPlayer").GetComponent<FoodSoundPlayer>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion
    }
}