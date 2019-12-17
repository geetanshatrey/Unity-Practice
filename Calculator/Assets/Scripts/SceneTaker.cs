using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneTaker : MonoBehaviour
  {
      public Text answerText;

      public void equalsTo()
      {
        SceneManager.LoadScene(2);
      }
      public void Start()
      {
          answerText.text=Operation.ans.ToString();
      }
      public void startMenu()
      {
          SceneManager.LoadScene(1);
      }
      public void askMenu()
      {
          SceneManager.LoadScene(2);
      }
      public void endMenu()
      {
          SceneManager.LoadScene(3);
      }
      public void exit()
      {
        Application.Quit();
      }
}
