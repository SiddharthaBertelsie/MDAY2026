using System.Collections.Generic;
using UnityEngine;

namespace MDAY2026.ItemGrabber
{
    public class ItemManager : MonoBehaviour
    {
        #region Variables

        [Header("Variables")]

        [Space(5)]

        // When we spawn in items from the menu, we'll want to add them to
        // this list when instantiating them
        public List<Item> items = new List<Item>();

        #endregion

        #region Methods

        private void InitialiseManager()
        {

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