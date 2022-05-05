using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] Text _shootCountText;

    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
    }
    public void PopulateShootCountText(int _shootCountOnPanel)
    {
        _shootCountText.text = _shootCountOnPanel.ToString();
    }
}
