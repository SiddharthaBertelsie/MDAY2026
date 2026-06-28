using UnityEngine;
using MDAY2026.ItemGrabber;
using MDAY2026.SoundEffects;

namespace MDAY2026.ItemMenu
{
    public class ItemSpawner : MonoBehaviour
    {
        #region Variables

        [Header("Variables")]

        [Space(5)]

        [SerializeField] private GameObject _itemToSpawn;

        [Tooltip("The position items will be instantiated at when the button is clicked")]
        [SerializeField] private Transform _itemSpawnPoint;

        [Header("Scripts")]

        [Space(5)]

        [SerializeField] private ItemManager _itemManager;

        [SerializeField] private FoodSoundPlayer _foodSoundPlayer;

        #endregion

        #region Methods

        public void SpawnItem()
        {
            Debug.Log("Button Clicked!");

            GameObject spawnedItemObject = Instantiate(_itemToSpawn, _itemSpawnPoint.position, Quaternion.identity);
            Item spawnedItemClass = spawnedItemObject.GetComponentInChildren<Item>();

            _foodSoundPlayer.PlaySFXClipAt("ItemSpawned", spawnedItemObject.transform.position, 1, true);

            _itemManager.AddToItemList(spawnedItemClass);
        }

        #endregion
    }
}