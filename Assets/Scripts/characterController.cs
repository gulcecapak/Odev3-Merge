using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody2D r2d;
    Animator _animator;
    Vector3 charPos;
    SpriteRenderer _spriteRenderer;
    [SerializeField] GameObject _camera;
    private int sayi;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>(); //caching sprite renderer
        r2d = GetComponent<Rigidbody2D>(); //caching r2d
        _animator = GetComponent<Animator>(); //caching anim
        charPos = transform.position;
        sayi = 1;

    }

    private void FixedUpdate() //50 fbs yani 50 kere yede yapýlacak
    {
        
        // r2d.velocity = new Vector2(speed, 0f);
        sayi = 2;
    }

    private void Update()  
    {
       
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos; //Hesapladýðým pozisyon karakterime iþlensin
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("speed", 0.0f);
        }
        else
        {
            _animator.SetFloat("speed", 1.0f);
        }

        if(Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        } else if(Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
        
        sayi = 3;
        Debug.Log("Update" + sayi);

    }

    private void LateUpdate()
    {
        //_camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);
        sayi = 4;

    }

}
