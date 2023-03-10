using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public bool showWinScreen = false;
    public bool showLossScreen = false;
    //UI Code
    public string labelText = "Shelve all 4 books and win!";
    public int maxItems = 4;

    private int _itemsCollected = 0;
    public int Items 
    {
        get { return _itemsCollected; }
        set 
        { 
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);
            if(_itemsCollected >= maxItems)
            {
                labelText = "You've shelved all the books!";
                showWinScreen = true;
                Time.timeScale = 0f;
            }
            else
            {
                labelText = "Book shelved, only " + (maxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    private int _playerHP = 10;
    public int HP
    {
        get { return _playerHP; }
        set {
            _playerHP = value;
            if(_playerHP <= 0)
            {
                labelText = "Better luck next time!";
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                labelText = "Shh... You're in a Library.";
            }
        }
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health: " + _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " + _itemsCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if(showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 - 50, 200, 100), "YOU WON!!"))
            {
                RestartLevel();
            }
        }
        if(showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 - 50, 200, 100), "You Lose..."))
            {
                RestartLevel();
            }
        }
    }
}
