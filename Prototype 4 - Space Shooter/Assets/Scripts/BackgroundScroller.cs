using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // Adjust this value in the Inspector
    private Material backgroundMaterial;
    private Vector2 offset;

    void Start()
    {
        // Get a reference to the material on the Quad's Renderer
        backgroundMaterial = GetComponent<Renderer>().material;
        offset = backgroundMaterial.mainTextureOffset;
    }

    void Update()
    {
        // Increment the X-offset (or Y-offset for vertical scrolling)
        offset.y += scrollSpeed * Time.deltaTime;

        // Apply the new offset to the material
        backgroundMaterial.mainTextureOffset = offset;
    }
}