using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class WaterfallAnimation : MonoBehaviour
    {
        public float scrollSpeed = 0.5f; // Adjust the speed of the scrolling texture

        new private Renderer renderer;
        private Material material;

        private void Start()
        {
            renderer = GetComponent<Renderer>();
            material = renderer.material;
        }

        private void Update()
        {
            // Calculate new offset values based on time and scrollSpeed
            //float offsetX = Time.time * scrollSpeed;
            float offsetX = 2;
            float offsetY = -(Time.time * scrollSpeed);

            // Set the new offset values for the "Stylize water" texture
            material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
            material.mainTextureOffset = new Vector2(offsetX, offsetY);
        }
    }
}
