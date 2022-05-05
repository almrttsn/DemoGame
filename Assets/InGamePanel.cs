using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGamePanel : MonoBehaviour
{
    [SerializeField] Text _shootCountText;

    public GameManager GameManager;

    public void Initialize(GameManager gameManager)
    {

    }
    public void PopulateShootCountText(int _shootCountOnPanel)
    {
        _shootCountText.text = _shootCountOnPanel.ToString();
    }
}
