using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private IRepuler _IRepulsion;

    private void Awake()
    {
        _IRepulsion = GetComponent<IRepuler>();
    }

    private void OnEnable()
    {
        _IRepulsion.OnRepulsion += ChangeColor;
    }

    private void OnDisable()
    {
        _IRepulsion.OnRepulsion -= ChangeColor;
    }

    private void ChangeColor()
    {
        _sprite.color = new Color(Random.Range(0.2f,1f),Random.Range(0.2f,1f),Random.Range(0.2f,1f));
    }
}
