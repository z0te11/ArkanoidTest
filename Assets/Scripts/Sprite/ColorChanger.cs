using UnityEngine;

namespace GAMEPLAY
{
    public class ColorChanger : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _sprite;
        
        private IRepuler _iRepulsion;

        private void Awake()
        {
            _iRepulsion = GetComponent<IRepuler>();
        }

        private void OnEnable()
        {
            _iRepulsion.OnRepulsion += ChangeColor;
        }

        private void OnDisable()
        {
            _iRepulsion.OnRepulsion -= ChangeColor;
        }

        private void ChangeColor()
        {
            _sprite.color = new Color(Random.Range(0.2f, 1f), Random.Range(0.2f, 1f), Random.Range(0.2f, 1f));
        }
    }
}
