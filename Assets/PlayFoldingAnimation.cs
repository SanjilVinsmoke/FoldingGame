using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFoldingAnimation : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

  public  void PlayFirstAnimation()
    {
        _animator.SetBool("Top",true);

    }
  public  void PlaySecondAnimation()
  {
      _animator.SetBool("Bottom",true);

  }

  public  void StopAnimation()
  {
      _animator.SetBool("Top",false);
      
    
        
  }
  public  void Stop1Animation()
  {
      _animator.SetBool("Bottom",false);

  }

}
