using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimationBox : MonoBehaviour
{
	private Animator _animator;

    public Button[] Buttons;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        
      
    }

    public void PlayAnimation1()
    {
        _animator.SetTrigger("Box1");
        
        
        
    }
    public void PlayAnimation2()
    {
        _animator.SetTrigger("Box2");
        
    }
    public void PlayAnimation3()
    {
        _animator.SetTrigger("Box3");
    }
    
}
