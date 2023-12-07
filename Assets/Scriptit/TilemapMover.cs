using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TilemapController : MonoBehaviour
{
    public float scrollSpeedMax;
    public float startSpeed;
    private Transform tilemapTransform;
    public Transform startPoint;
    public Transform endPoint;
    public Transform Player;
    private float mapDistance;
    public TextMeshProUGUI textMeshPro;

    private void Start()
    {
        tilemapTransform = GetComponent<Transform>();
        mapDistance = endPoint.position.x - startPoint.position.x;
    }

    private void Update()
    {
        float distanceToEnd = endPoint.position.x - Player.position.x;
        float progression = 1f - distanceToEnd / mapDistance;
        float speed = Mathf.Lerp(startSpeed, scrollSpeedMax, progression);

        float offsetX = Time.deltaTime * speed;
        tilemapTransform.Translate(Vector3.left * offsetX);
        textMeshPro.text = progression.ToString("P0");
    }
}



