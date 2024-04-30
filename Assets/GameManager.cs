using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public TMP_Text FruitText;

    private int _fruitCount = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddFruit()
    {
        FruitText.text = _fruitCount < 1 ? $"Fruit: {++_fruitCount}/6" : $"Fruits: {++_fruitCount}/6";
    }
}
