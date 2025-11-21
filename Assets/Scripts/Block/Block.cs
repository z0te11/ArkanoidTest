using UnityEngine;

namespace GAMEPLAY
{
    public class Block : MonoBehaviour, IScore, ISound
    {
        public event System.Action OnRepulsion;
        public event System.Action OnDestroyed;
        
        [SerializeField] private Animator _animator; 
        [SerializeField] private int _lives = 5;
        [SerializeField] private int _score = 10;
        
        public int Score
        {
            get
            {
                return _score;
            }
        }
        
        public void GetScore(int score)
        {
            ScoreManager.Instance.AddScore(score);
        }
        
        protected void GetDamage()
        {
            _lives -= 1;

            if (_lives <= 0)
            {
                DestroyGameObject();
            }
            else
            {
                OnRepulsion?.Invoke();
            }
        }

        protected void DestroyGameObject()
        {
            GetScore(Score);

            _animator.Play("BlockDestroy");

            BlockManager.Instance.RemoveBlockFromList(this.gameObject);

            OnDestroyed?.Invoke();

            AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);
            float animationLength = stateInfo.length;

            Destroy(gameObject, animationLength);
        }
    }
}
