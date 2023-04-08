using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameBehavior : MonoBehaviour
{
    // public bool showWinScreen = false;
    // public bool showLossScreen = false;
    // //UI Code
    // public string labelText = "Shelve all 4 books and win!";
    public int maxItems = 4;

    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;

    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
    }
    
    public Button WinButton;
    private int _itemsCollected = 0;
    public int Items 
    {
        get { return _itemsCollected; }
        set 
        { 
            _itemsCollected = value;
            ItemText.text = "Items Collected: " + Items;
            if(_itemsCollected >= maxItems)
            {
                ProgressText.text = "You've shelved all the books!";
                WinButton.gameObject.SetActive(true);
                StartCoroutine(EndScreen());
            }
            else
            {
                ProgressText.text = "Book shelved, only " + (maxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    private int _playerHP = 10;
    public int HP
    {
        get { return _playerHP; }
        set {
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;
            ProgressText.text = "Shh... You're in a Library.";
            }
        
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    IEnumerator EndScreen()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
