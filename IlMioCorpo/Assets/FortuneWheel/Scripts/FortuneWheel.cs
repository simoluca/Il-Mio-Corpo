namespace Curiologix
{
    using UnityEngine;
    using System.Collections;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;
    using System.Collections.Generic;
    //using Random = System.Random;  

     
        
    public class FortuneWheel : MonoBehaviour
    {
        public SlotScriptSpinaDorsale SpinaDorsale;
  
        
        [Header("UI Properties")]

        public Button spinButton;
        public Text coinsText, selectedText;
        public TimerForSpin timer4Spin;
        public const string COINS_COUNT = "COINS_COUNT";
        [Space(20)]
        [Header("Fortune Wheel Properties")]
        public Transform wheelToRotate;
        public Transform wheelPartsParent, lightsParent;
        public GameObject DiCosaSonoFatto, QuizOcchi, QuizIntestinoCrasso, QuizOssaGambe, QuizOssaPiedi, QuizSpinaDorsale, QuizStomaco, QuizVescica;
        public GameObject winParticles;
        //Random random = new Random();

        int _selectReward, _coins, cost = 300;
        int count = 0;
        AudioSource[] audSource;
        WheelPart[] wheelParts;
        DotLight[] lightObjs;
        Sprite[] dots = new Sprite[2];
        bool spinning;
        float anglePerReward, anglePerLight;

        // list for active (non completed) quizes.
        // completed quizes will be removed from the list and not be considered by the wheel spin
        
       List<int> QuizesList = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12};
       List<string> QuizesListNames = new List<string>() {"LargeIntestine", "SmallIntestine", "Stomach", "Bladder", "RibCage", "Heart", "Legbone"};

        //indexOf
        

        public int rewardCount { get { return FortuneWheelConfig.Instance.prizes.Length; } }
        public int lightCount { get { return lightObjs.Length; } }
        public int Coins
        {
            get { return _coins; }
            set
            {
                _coins = value;
                coinsText.text = FortuneWheelConfig.GetValueFormated(_coins);
            }
        }
        
        public int SelectedReward
        {
            
            get
            {
                
                if(_selectReward == 1)
                  {
                                        
                                        /*
                                        DiCosaSonoFatto.SetActive(true);
                                        QuizIntestinoCrasso.SetActive(true);
                                        */
                                        //Debug.Log(QuizesList[0]);
                                        /*
                                        for(int i = 0; i < QuizesListNames.Count; i++)
                                        {
                                            if(QuizesListNames[i].Equals("LargeIntestine"))
                                            {
                                                Debug.Log("LARGE INTESTINE is chosen");

                                                //only when done
                                                QuizesListNames.RemoveAt(i);
                                                QuizesList.RemoveAt(i);

                                            }
                                        }
                                        */

                //    QuizesList.Remove(1);

                                    //   DiCosaSonoFatto.SetActive(true);
                                        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                                    //   QuizIntestinoCrasso.SetActive(true);

                    
                 

                  }
                     if(_selectReward == 2)
                  {
                    
                  //  QuizesList.RemoveAt(1);
                    //Debug.Log(QuizesList[1]);
                    /*
                     for(int i = 0; i < QuizesListNames.Count; i++)
                                     {
                                        if(QuizesListNames[i].Equals("SmallIntestine"))
                                        {
                                            Debug.Log("SMALL INTESTINE is chosen");
                                            QuizesListNames.RemoveAt(i);
                                            QuizesList.RemoveAt(i);

                                        }
                                     }
                                     */
                 //   QuizesList.Remove(2);

                    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


                 }             
                      
                  if(_selectReward == 3)
                  {
                    
                    /*
                    DiCosaSonoFatto.SetActive(true);
                    QuizStomaco.SetActive(true);
                    */
                    /*
                    for(int i = 0; i < QuizesListNames.Count; i++)
                        {
                            if(QuizesListNames[i].Equals("Stomach"))
                            {
                                Debug.Log("STOMACH is chosen");
                                QuizesListNames.RemoveAt(i);
                                                                                QuizesList.RemoveAt(i);

                            }
                        }
                        */
                     //       QuizesList.Remove(3);


                 // QuizesList.RemoveAt(2);
                  //Debug.Log(QuizesList[2]);
                    // DiCosaSonoFatto.SetActive(true);
                    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
                    //   QuizStomaco.SetActive(true);
                 
                  }
                  if(_selectReward == 4)
                  {
                    
                    /*
                    DiCosaSonoFatto.SetActive(true);
                    QuizVescica.SetActive(true);
                    */
                    //QuizesList.RemoveAt(3);
                    /*
                      for(int i = 0; i < QuizesListNames.Count; i++)
                        {
                            if(QuizesListNames[i].Equals("Bladder"))
                            {
                                Debug.Log("BLADDER is chosen");
                                QuizesListNames.RemoveAt(i);
                                                                                QuizesList.RemoveAt(i);

                            }
                        }
                        */
                   //     QuizesList.Remove(4);
                  //Debug.Log(QuizesList[3]);
                    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                 
                  }
                  if(_selectReward == 5)
                  {
                    
                   // DiCosaSonoFatto.SetActive(true);
                   /*
                    for(int i = 0; i < QuizesListNames.Count; i++)
                        {
                            if(QuizesListNames[i].Equals("Spine"))
                            {
                                Debug.Log("spine is chosen");
                                QuizesListNames.RemoveAt(i);    
                                QuizesList.RemoveAt(i);

                            }
                        }
                        */

                 //  QuizesList.Remove(5);
                  // Debug.Log(QuizesList[4]);
                  /*
                                     Debug.Log("SPINE is chosen");
                                     QuizSpinaDorsale.SetActive(true);
                                     
                                     if(SpinaDorsale.Finished == true) 
                                     {
                                        Debug.Log("spina dorsale completato");
                                        QuizesList.RemoveAt(4);
                                        QuizSpinaDorsale.SetActive(false);
                                        DiCosaSonoFatto.SetActive(false);

                                     }
                                     */
                                     
                                  //    DiCosaSonoFatto.SetActive(true);
                                     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                                 //   QuizSpinaDorsale.SetActive(true);
                 
                  }
                   if(_selectReward == 6)
                  {
                    /*
                      for(int i = 0; i < QuizesListNames.Count; i++)
                        {
                            if(QuizesListNames[i].Equals("RibCage"))
                            {
                                Debug.Log("RibCage is chosen");
                                QuizesListNames.RemoveAt(i);
                                 QuizesList.RemoveAt(i);
                            }
                        }
                        */
                    //    QuizesList.Remove(6);
                 //  QuizesList.RemoveAt(5);
                                  //   Debug.Log("RIB CAGE is chosen");
                                     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                 
                  }
                   if(_selectReward == 7)
                  {
                    /*
                        for(int i = 0; i < QuizesListNames.Count; i++)
                        {
                            if(QuizesListNames[i].Equals("Heart"))
                            {
                                Debug.Log("Heart is chosen");
                                QuizesListNames.RemoveAt(i);
                                 QuizesList.RemoveAt(i);
                            }
                        }
                        */
                  //      QuizesList.Remove(7);
                //  QuizesList.RemoveAt(6);
                             //        Debug.Log("HEART is chosen");
                                     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                 
                  }
                    if(_selectReward == 8)
                 {
                    /*
                    for(int i = 0; i < QuizesListNames.Count; i++)
                        {
                            if(QuizesListNames[i].Equals("Legbone"))
                            {
                                Debug.Log("Legbone is chosen");
                                QuizesListNames.RemoveAt(i);
                                 QuizesList.RemoveAt(i);
                            }
                        }
                        */
                  //      QuizesList.Remove(8);

                  //QuizesList.RemoveAt(7);
                    //                 Debug.Log("LEG BONE is chosen");
                                   //   DiCosaSonoFatto.SetActive(true);
                                     //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                                //    QuizOssaGambe.SetActive(true);
                 }
                    if(_selectReward == 9)
                 {
                // QuizesList.RemoveAt(8);
                  //                   Debug.Log("HAND is chosen");
              //    QuizesList.Remove(9);
                  //Debug.Log("no quiz yet");
                                    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                 }
                    if(_selectReward == 10)
                 {
               //     QuizesList.Remove(10);
                            //          Debug.Log("no quiz yet");

                 // QuizesList.RemoveAt(9);
                   //                  Debug.Log("LUNGS are chosen");
                                   //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                 }
                    if(_selectReward == 11)
                 {
              //      QuizesList.Remove(11);
                                      //Debug.Log("no quiz yet");

                 //QuizesList.RemoveAt(10);
                   //                  Debug.Log("kidneys chosen");
                                  //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                 }
                    if(_selectReward == 12)
                 {
              //      QuizesList.Remove(12);
                                      //Debug.Log("no quiz yet");

                // QuizesList.RemoveAt(11);
                  //                   Debug.Log("SKULL is chosen");
                                   //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                 }

                
                return _selectReward;                        
                
            }
            set
            {
                _selectReward = Mathf.Clamp(value, 0, FortuneWheelConfig.Instance.prizes.Length);
                // Debug.Log(_selectReward);
                 

                    if (spinning)
                    {
                        selectedText.text = FortuneWheelConfig.GetValueFormated(FortuneWheelConfig.Instance.prizes[_selectReward]);
                        /*
                        if (selectedText.text == "200")
                        {
                                    Debug.Log("START");
                        }
                        */
                    }
                else
                {
                    
                    selectedText.text = "empty";
                }
            }
        }
        public void onClickSpinNow()
        {
            if (Coins >= cost)
            {
                Coins -= cost;
                spinButton.interactable = false;
                StartSpin();
            }
        }

        void Awake()
        {
            dots[0] = FortuneWheelConfig.Instance.illuminatiDots[0];
            dots[1] = FortuneWheelConfig.Instance.illuminatiDots[1];
            Coins = PlayerPrefs.GetInt(COINS_COUNT, 3000);
            timer4Spin.gameObject.SetActive(true);
            spinButton.onClick.AddListener(onClickSpinNow);
            spinning = false;
            anglePerReward = 360 / rewardCount;
            wheelParts = wheelPartsParent.GetComponentsInChildren<WheelPart>();
            for (int i = 0; i < rewardCount; i++)
            {
                wheelParts[i].transform.localEulerAngles = new Vector3(0, 0, (i * -anglePerReward));
            }
            lightObjs = lightsParent.GetComponentsInChildren<DotLight>();
           int lights = lightCount + 7;
            anglePerLight = 360 / lights;
            int objID = 0;
            for (int i = 0; i < lights; i++)
            {
                if (i >= 7 && i <= 13) continue;
                lightObjs[objID].transform.localEulerAngles = new Vector3(0, 0, (i * -anglePerLight));
                objID++;
            }
            
            audSource = new AudioSource[5];
            for (int i = 0; i < 5; i++)
            {
                AudioSource source = gameObject.AddComponent<AudioSource>();
                source.playOnAwake = false;
                source.loop = false;
                audSource[i] = source;
            }
          //  AnimateWheel(true);
        }

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

       // public int targetToStopOn { get { return Random.Range(0, 12); } }
        public int targetToStopOn 
        {
           
            get {
                
                int QuizToRemove = Random.Range(0, QuizesList.Count);
                QuizesList.RemoveAt(QuizToRemove);
                Debug.Log(QuizesList.Count);
                //Debug.Log(QuizToRemove);
                return QuizToRemove;
            
              //   Debug.Log(QuizesList[i]);

           // Console.WriteLine(QuizesList[i]);
            
            
             //Debug.Log(QuizesList.Count);

                
                // something else needed other than range?
                //return Random.Range(0, QuizesList.Range);
              //  return Random.Range(0, QuizesList.Count);
                // return Random.Range(0, QuizesList.Count);
             } 
        }


        public void StartSpin()
        {
            if (!spinning)
            {
                float maxAngle = 360 * FortuneWheelConfig.Instance.speedMultiplier + targetToStopOn * anglePerReward;
         //       AnimateWheel(false);
                StartCoroutine(RotateWheel(FortuneWheelConfig.Instance.duration, maxAngle));
            }
        }
        IEnumerator RotateWheel(float time, float maxAngle)
        {
            spinning = true;
            float timer = 0.0f;
            float startAngle = wheelToRotate.transform.eulerAngles.z;
            maxAngle = maxAngle - startAngle;
            while (timer < time)
            {
                //to calculate rotation
                float angle = maxAngle * FortuneWheelConfig.Instance.animationCurve.Evaluate(timer / time);
                wheelToRotate.transform.eulerAngles = new Vector3(0.0f, 0.0f, angle + startAngle);
                timer += Time.deltaTime;
                yield return 0;
            }
            wheelToRotate.transform.eulerAngles = new Vector3(0.0f, 0.0f, maxAngle + startAngle);
            StartCoroutine(ShowHideParticles());
            StartCoroutine(IncrementCoroutine(coinsText, Coins + FortuneWheelConfig.Instance.prizes[SelectedReward], Coins));

        }
        void GivePrize()
        {
            
            AnimateWheel(true);
            spinning = false;
                        // at this point in time the spin stops
                        //Debug.Log("object is selected");
                        
            spinButton.interactable = Coins >= cost;
          //  Coins += FortuneWheelConfig.Instance.prizes[SelectedReward];
           // SelectedReward = 0;
        }
        IEnumerator ShowHideParticles()
        {
            winParticles.gameObject.SetActive(true);
            yield return new WaitForSeconds(2.5f);
            winParticles.gameObject.SetActive(false);
            GivePrize();
        }
        private IEnumerator IncrementCoroutine(Text l, int targetValue, int startingValue = 0)
        {
            float time = 0;
            l.text = startingValue.ToString();
            float incrementTime = 1.5f;
            while (time < incrementTime)
            {
                yield return null;
                time += Time.deltaTime;
                float factor = time / incrementTime;
                l.text = FortuneWheelConfig.GetValueFormated((int)Mathf.Lerp(startingValue, targetValue, factor));
            }
            l.text = FortuneWheelConfig.GetValueFormated(targetValue);
            yield break;
        }
        internal void HitStart(SpriteRenderer sp)
        {
            PlayHitClip();
        }
        
        public void AnimateWheel(bool playAnim)
        {
            StopAllCoroutines();
            foreach (var item in lightObjs)
            {
                item.spRend.sprite = dots[0];
            }

            if (playAnim)
            {
                StartCoroutine(PlayAnimationWhenStationary(dots[0], dots[1]));
            }
            else
            {
                StartCoroutine(LightAnimDuringSpinning(0));
                StartCoroutine(LightAnimDuringSpinning(10));
                StartCoroutine(LightAnimDuringSpinning(20));
            }
        }

        IEnumerator PlayAnimationWhenStationary(Sprite sp1, Sprite sp2)
        {
            yield return new WaitForSeconds(0.2f);
            count++;
            for (int i = 0; i < lightObjs.Length; i++)
            {
                lightObjs[i].spRend.sprite = (i % 2 == 0) ? sp1 : sp2;
            }
            if (count < Random.Range(10, 30))
            {
                StartCoroutine(PlayAnimationWhenStationary(sp2, sp1));
            }
            else
            {
                StartCoroutine(SymetricLightMovement(0));
            }
        }
        IEnumerator LightAnimDuringSpinning(int index)
        {
            yield return new WaitForSeconds(0.05f);
            if (index < lightObjs.Length - 1)
            {
                lightObjs[index].spRend.sprite = dots[1];
                lightObjs[index + 1].spRend.sprite = dots[1];
                yield return new WaitForSeconds(0.1f);
                lightObjs[index].spRend.sprite = dots[0];
                lightObjs[index + 1].spRend.sprite = dots[0];
                StartCoroutine(LightAnimDuringSpinning(index + 2));
            }
            else
            {
                StartCoroutine(LightAnimDuringSpinning(0));
            }
        }
        IEnumerator SymetricLightMovement(int index)
        {
            if (index >= lightObjs.Length)
            {
                count = 0;
                StartCoroutine(PlayAnimationWhenStationary(dots[0], dots[1]));
            }
            else
            {
                lightObjs[index].spRend.sprite = dots[1];
                yield return new WaitForSeconds(0.05f);
                lightObjs[index].spRend.sprite = dots[0];
                yield return new WaitForSeconds(0.0f);
                StartCoroutine(SymetricLightMovement(index + 1));
            }
        }
        
        public void PlayHitClip()
        {
            for (int i = 0; i < audSource.Length; i++)
            {
                if (!audSource[i].isPlaying)
                {
                    audSource[i].clip = FortuneWheelConfig.Instance.tingSound;
                    audSource[i].Play();
                    break;
                }
            }
        }
        private void OnApplicationPause(bool pause)
        {
            if (pause)
            {
                PlayerPrefs.SetInt(COINS_COUNT, Coins);
                PlayerPrefs.Save();
            }
        }
        private static FortuneWheel _instance;
        public static FortuneWheel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<FortuneWheel>();
                }
                return _instance;
            }
        }
    }
}