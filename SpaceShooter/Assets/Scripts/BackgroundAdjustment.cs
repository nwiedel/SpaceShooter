using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class BackgroundAdjustment : MonoBehaviour
{
    public Camera Camera;
    public SpriteRenderer SpriteRenderer;

    private void Start()
    {
        float worldSpaceHeight = Camera.orthographicSize * 2f;
        float worldSpaceWidth = worldSpaceHeight * Camera.aspect;

        SpriteRenderer.size = new Vector2(worldSpaceWidth, worldSpaceHeight);
    }
}
