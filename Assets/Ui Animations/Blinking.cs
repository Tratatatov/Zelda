using UnityEngine;
using UnityEngine.UI;

public class Blinking : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _color;
    [SerializeField] private Color _firstColor;
    [SerializeField] private Color _secondColor;
    [SerializeField] private float _speed;
    void Start()
    {
        _color = _image.color;
    }

    void Update()
    {
        _color = Color.Lerp(_firstColor, _secondColor, Mathf.PingPong(Time.time * _speed, 1));
        _image.color = _color;
    }
    
}
