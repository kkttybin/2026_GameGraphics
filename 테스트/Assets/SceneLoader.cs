using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
 public void LoadScene(string Stage1)
 {
  SceneManager.LoadScene(Stage1);
 }
 public void ReloadScene()
 {
  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }
}
