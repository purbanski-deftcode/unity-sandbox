using UnityEngine;

namespace Deftcode.Sandbox._Sandbox
{
    public class DebugTest : MonoBehaviour
    {
        [SerializeField] private float speed = 2f;

        private int _frameCount;
        private float _elapsed;

        private void Start()
        {
            Debug.Log($"DebugTest started on {gameObject.name}");
        }

        private void Update()
        {
            _frameCount++;
            _elapsed += Time.deltaTime;

            // Visible effect: move right/left over time
            transform.position = new Vector3(Mathf.Sin(_elapsed * speed) * 3f, 0f, 0f);

            if (_frameCount % 120 == 0)
            {
                Debug.Log($"Frame {_frameCount}, elapsed {_elapsed:F2}s");
            }
        }
    }
}