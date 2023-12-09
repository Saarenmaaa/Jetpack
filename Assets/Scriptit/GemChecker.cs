using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemChecker : MonoBehaviour
{
    public List<GameObject> CanvasGemArray;
    public void Gem()
    {
        GameObject firstGem = CanvasGemArray[0];
        Image gemImage = firstGem.GetComponent<Image>();
        Color currentColor = gemImage.color;
        currentColor.a = 1f;
        gemImage.color = currentColor;
        CanvasGemArray.RemoveAt(0);
    }
}
