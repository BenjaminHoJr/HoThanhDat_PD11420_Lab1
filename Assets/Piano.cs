using UnityEngine;

public class Piano : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color pressedColor = Color.gray; // Màu khi nhấn
    private Color originalColor; // Màu gốc

    AudioSource _Do, _re, _mi, _fa, _son, _la, _si;
    void Start()
    {
        Debug.Log("Start");
        _Do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();

        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Press A");
            _Do.Play();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Press S");
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Press D");
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Press F");
            _fa.Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Press G");
            _son.Play();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Press H");
            _la.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Press J");
            _si.Play();
        }
    }
    void OnMouseDown()
    {
        spriteRenderer.color = pressedColor; // Đổi màu khi bấm
    }

    void OnMouseUp()
    {
        spriteRenderer.color = originalColor; // Quay lại màu gốc khi thả
    }
}
