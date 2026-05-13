using MDAY2026.FoodCreation;
using MDAY2026.ItemGrabber;
using TMPro;
using UnityEngine;

namespace MDAY2026.FoodConditions
{
    public class FoodConditionChecker : MonoBehaviour
    {
        #region Variables

        public enum FoodConditions { SpaghettiBolognese = 0, SatayChicken = 1, Burgers = 2, BeefRagu = 3, Fajitas = 4} // Causes error if below Header and Space

        [Header("Parameters")]

        [Space(5)]

        [SerializeField] private FoodConditions _foodConditions;

        [Header("Conditions")]

        [Space(5)]

        [SerializeField] private bool _hasFruit;

        [SerializeField] private bool _hasGrain;

        [SerializeField] private bool _hasPlant;

        [SerializeField] private bool _hasVegetable;

        [SerializeField] private bool _hasSpread;

        [SerializeField] private bool _hasCondiment;

        [SerializeField] private bool _hasPasta;

        [SerializeField] private bool _hasMeat;

        [Header("Canvas Elements")]

        [SerializeField] private TextMeshProUGUI _foodConditionText;

        [Header("Scripts")]

        [Space(5)]

        [SerializeField] private FoodParenter _foodParenter;

        #endregion

        #region Methods

        private void CheckForMetConditions()
        {
            // Different item types:
            //Fruit
            //
            //Grain
            //
            //Plant
            //
            //Vegetable
            //
            //Spread
            //
            //Condiment
            //
            //Pasta
            //
            //Meat
            switch ( _foodConditions)
            {
                case FoodConditions.SpaghettiBolognese:
                    foreach (Item item in _foodParenter.ParentedItems)
                    {
                        // Check for specifif conditions here

                        switch (item.ItemType)
                        {
                            case "Pasta":
                                if (_hasPasta == false)
                                {
                                    _hasPasta = true;
                                }
                                break;
                            case "Meat":
                                if (_hasMeat == false)
                                {
                                    _hasMeat = true;
                                }
                                break;
                            case "Condiment":
                                if (_hasCondiment == false)
                                {
                                    _hasCondiment = true;
                                }
                                break;
                            case "Plant":
                                if (_hasPlant == false)
                                {
                                    _hasPlant = true;
                                }
                                break;
                        }
                    }
                    break;
                case FoodConditions.SatayChicken:
                    foreach (Item item in _foodParenter.ParentedItems)
                    {
                        // Check for specifif conditions here

                        switch (item.ItemType)
                        {
                            case "Grain":
                                if (_hasGrain == false)
                                {
                                    _hasGrain = true;
                                }
                                break;
                            case "Meat":
                                if (_hasMeat == false)
                                {
                                    _hasMeat = true;
                                }
                                break;
                            case "Condiment":
                                if (_hasCondiment == false)
                                {
                                    _hasCondiment = true;
                                }
                                break;
                            case "Plant":
                                if (_hasPlant == false)
                                {
                                    _hasPlant = true;
                                }
                                break;
                        }
                    }
                    break;
                case FoodConditions.Burgers:
                    foreach (Item item in _foodParenter.ParentedItems)
                    {
                        // Check for specifif conditions here

                        switch (item.ItemType)
                        {
                            case "Grain":
                                if (_hasGrain == false)
                                {
                                    _hasGrain = true;
                                }
                                break;
                            case "Meat":
                                if (_hasMeat == false)
                                {
                                    _hasMeat = true;
                                }
                                break;
                            case "Vegetable":
                                if (_hasVegetable == false)
                                {
                                    _hasVegetable = true;
                                }
                                break;
                            case "Fruit":
                                if (_hasFruit == false)
                                {
                                    _hasFruit = true;
                                }
                                break;
                            case "Plant":
                                if (_hasPlant == false)
                                {
                                    _hasPlant = true;
                                }
                                break;
                            case "Condiment":
                                if (_hasCondiment == false)
                                {
                                    _hasCondiment = true;
                                }
                                break;
                            case "Spread":
                                if (_hasSpread == false)
                                {
                                    _hasSpread = true;
                                }
                                break;
                        }
                    }
                    break;
                case FoodConditions.BeefRagu:
                    foreach (Item item in _foodParenter.ParentedItems)
                    {
                        // Check for specifif conditions here

                        switch (item.ItemType)
                        {
                            case "Pasta":
                                if (_hasPasta == false)
                                {
                                    _hasPasta = true;
                                }
                                break;
                            case "Meat":
                                if (_hasMeat == false)
                                {
                                    _hasMeat = true;
                                }
                                break;
                            case "Vegetable":
                                if (_hasVegetable == false)
                                {
                                    _hasVegetable = true;
                                }
                                break;
                            case "Plant":
                                if (_hasPlant == false)
                                {
                                    _hasPlant = true;
                                }
                                break;
                            case "Condiment":
                                if (_hasCondiment == false)
                                {
                                    _hasCondiment = true;
                                }
                                break;
                        }
                    }
                    break;
                case FoodConditions.Fajitas:
                    foreach (Item item in _foodParenter.ParentedItems)
                    {
                        // Check for specifif conditions here

                        switch (item.ItemType)
                        {
                            case "Grain":
                                if (_hasGrain == false)
                                {
                                    _hasGrain = true;
                                }
                                break;
                            case "Meat":
                                if (_hasMeat == false)
                                {
                                    _hasMeat = true;
                                }
                                break;
                            case "Vegetable":
                                if (_hasVegetable == false)
                                {
                                    _hasVegetable = true;
                                }
                                break;
                            case "Fruit":
                                if (_hasFruit == false)
                                {
                                    _hasFruit = true;
                                }
                                break;
                            case "Plant":
                                if (_hasPlant == false)
                                {
                                    _hasPlant = true;
                                }
                                break;
                            case "Condiment":
                                if (_hasCondiment == false)
                                {
                                    _hasCondiment = true;
                                }
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public float GetGrade()
        {
            float grade = 0;

            switch (_foodConditions)
            {
                case FoodConditions.Burgers:
                    if (_hasGrain == true)
                    {
                        grade += 0.71f;
                    }
                    if (_hasMeat == true)
                    {
                        grade += 0.71f;
                    }
                    if ( _hasVegetable == true)
                    {
                        grade += 0.71f;
                    }
                    if (_hasFruit == true)
                    {
                        grade += 0.71f;
                    }
                    if (_hasPlant == true)
                    {
                        grade += 0.71f;
                    }
                    if ( _hasCondiment == true)
                    {
                        grade += 0.71f;
                    }
                    if (_hasSpread == true)
                    {
                        grade += 0.71f;
                    }
                    return Mathf.Round(grade);
                case FoodConditions.SpaghettiBolognese:
                    if (_hasPasta == true)
                    {
                        grade += 1.25f;
                    }
                    if (_hasMeat == true)
                    {
                        grade += 1.25f;
                    }
                    if (_hasPlant == true)
                    {
                        grade += 1.25f;
                    }
                    if (_hasCondiment == true)
                    {
                        grade += 1.25f;
                    }
                    return Mathf.Round(grade);
                case FoodConditions.Fajitas:
                    if (_hasGrain == true)
                    {
                        grade += 0.83f;
                    }
                    if (_hasMeat == true)
                    {
                        grade += 0.83f;
                    }
                    if (_hasVegetable == true)
                    {
                        grade += 0.83f;
                    }
                    if (_hasFruit == true)
                    {
                        grade += 0.83f;
                    }
                    if (_hasPlant == true)
                    {
                        grade += 0.83f;
                    }
                    if (_hasCondiment == true)
                    {
                        grade += 0.83f;
                    }
                    return Mathf.Round(grade);
                case FoodConditions.BeefRagu:
                    if (_hasPasta == true)
                    {
                        grade += 1f;
                    }
                    if (_hasMeat == true)
                    {
                        grade += 1;
                    }
                    if (_hasVegetable == true)
                    {
                        grade += 1f;
                    }
                    if (_hasPlant == true)
                    {
                        grade += 1f;
                    }
                    if (_hasCondiment == true)
                    {
                        grade += 1f;
                    }
                    return Mathf.Round(grade);
                case FoodConditions.SatayChicken:
                    if (_hasGrain == true)
                    {
                        grade += 1.25f;
                    }
                    if (_hasMeat == true)
                    {
                        grade += 1.25f;
                    }
                    if (_hasPlant == true)
                    {
                        grade += 1.25f;
                    }
                    if (_hasCondiment == true)
                    {
                        grade += 1.25f;
                    }
                    return Mathf.Round(grade);
                default:
                    return grade;
            }
        }

        private void InitialiseConditions()
        {
            int index = (int)Random.Range(0, 4);

            _foodConditions = (FoodConditions)index;

            _foodConditionText.text = "Meal: " + ConditionAsString(); 
        }

        private string ConditionAsString()
        {
            switch (_foodConditions)
            {
                case FoodConditions.Burgers:
                    return "Burger";
                case FoodConditions.SpaghettiBolognese:
                    return "Spaghetti Bolognese";
                case FoodConditions.Fajitas:
                    return "Fajitas";
                case FoodConditions.BeefRagu:
                    return "Beef Ragu";
                case FoodConditions.SatayChicken:
                    return "Satay Chicken";
                default:
                    return "";
            }
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            InitialiseConditions();
        }

        // Update is called once per frame
        void Update()
        {
            CheckForMetConditions();
        }

        #endregion
    }
}