using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Move : MonoBehaviour
{
    [SerializeField]
    private Color _pressColor = new Color(0.33f, 1f, 0.04f);

    [SerializeField]
    private Text _key1Info, _key2Info;

    private Rigidbody2D _rb;
    private Color _defaultColor;
    private bool _key1, _key2;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _defaultColor = _key1Info.color;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _key1 = true;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            _key2 = true;

        _key1Info.color = _key1 ? _pressColor : _defaultColor;
        _key2Info.color = _key2 ? _pressColor : _defaultColor;
    }

    private void FixedUpdate()
    {
        if (_key1)
            _rb.MovePosition(_rb.position + Vector2.right);
        else if (_key2)
            _rb.position += Vector2.right;

        _key1 = _key2 = false;
    }
}