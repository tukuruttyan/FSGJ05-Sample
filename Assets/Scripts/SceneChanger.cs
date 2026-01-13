using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] Button button;
    
    private void Awake()
    {
        if (button != null)
        {
            button.onClick.AddListener(Change);
        }
    }
    
    public void Change()
    {
        SceneManager.LoadScene(sceneName);
    }
}
