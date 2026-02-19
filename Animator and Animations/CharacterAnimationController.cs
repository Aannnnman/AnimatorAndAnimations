using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _animator.GetCurrentAnimatorStateInfo(0).IsName("PlayerIdle"))
        {
            _animator.Play("PlayerAttack");
            Debug.Log("Click");
        }
    }
}
