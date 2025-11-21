using Doozy.Runtime.UIManager.Containers;
using UnityEngine;

namespace GAMEPLAY
{
    public class UIManager : MonoBehaviour
    {
        [Header("UI Views")]
        [SerializeField] private UIView _startMenuView;
        [SerializeField] private UIView _finishMenuView;

        public static UIManager Instance = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        private void OnEnable()
        {
            GameManager.OnGameFinished += ShowFinishMenuView;
            GameManager.OnGameStarted += HideStartMenuView;
        }

        private void OnDisable()
        {
            GameManager.OnGameFinished -= ShowFinishMenuView;
            GameManager.OnGameStarted -= HideStartMenuView;
        }

        private void Start()
        {
            HideFinishMenuView();
            ShowStartMenuView();
        }

        public void HideStartMenuView()
        {
            _startMenuView.Hide();
        }

        public void ShowStartMenuView()
        {
            _startMenuView.Show();
        }

        public void HideFinishMenuView()
        {
            _finishMenuView.Hide();
        }

        public void ShowFinishMenuView()
        {
            _finishMenuView.Show();
        }
    }
}