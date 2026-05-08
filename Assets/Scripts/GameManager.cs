using UnityEditor.PackageManager;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Static Declaration

    public static GameManager instance;

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

    [Header("Variables")]

    [SerializeField] private bool _gameOver;
    public bool GameOver { get { return _gameOver; } set { _gameOver = value; } }

    #endregion

    #region Methods

    public void EndGame()
    {
        _gameOver = true;
        
        // Do other stuff here
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
