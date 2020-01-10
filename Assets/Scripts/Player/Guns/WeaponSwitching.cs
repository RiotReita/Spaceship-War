using UnityEngine;

namespace Spaceship_war
{
    public class WeaponSwitching : MonoBehaviour
    {
        public int selectedWeaponLight = 0;
        public int selectedWeaponHeavy = 0;

        public float ChoiceRateWL = 5f;
        public float ChoiceRateWH = 5f;
        private float nextTimeToChangeWL = 0f;
        private float nextTimeToChangeWH = 0f;

        public int lightWeaponCount;
        public int heavyWeaponCount;
        private GameObject[] lightWeapons;
        private GameObject[] heavyWeapons;

        private void Awake()
        {
            GetAllLightWeapons();
            GetAllHeavyWeapons();
        }

        void Start()
        {
            SelectWeaponLight();
            SelectWeaponHeavy();
        }

        private void Update()
        {
        
        }

        private void FixedUpdate()
        {
            ChoicerWeaponLight();
            ChoicerWeaponHeavy();
        }

        void GetAllLightWeapons()
        {
            lightWeapons = GameObject.FindGameObjectsWithTag("LightWeapon");
            lightWeaponCount = lightWeapons.Length;
            foreach (GameObject lightWeapon in lightWeapons)
            {
                lightWeapon.SetActive(false);
            }
        }

        void GetAllHeavyWeapons()
        {
            heavyWeapons = GameObject.FindGameObjectsWithTag("HeavyWeapon");
            heavyWeaponCount = heavyWeapons.Length;
            foreach (GameObject heravyWeapon in heavyWeapons)
            {
                heravyWeapon.SetActive(false);
            }
        }


        void ChoicerWeaponLight()
        {
            int previousSelectedWeaponLight = selectedWeaponLight;

            if (VirtualInputManager.Instance.SelectLightFire && Time.time > nextTimeToChangeWL)
            {
                if (selectedWeaponLight >= lightWeaponCount - 1)
                {
                    selectedWeaponLight = 0;
                }
                else
                {
                    selectedWeaponLight++;
                }
                nextTimeToChangeWL = Time.time + ChoiceRateWL;
            }

            if (previousSelectedWeaponLight != selectedWeaponLight)
            {
                SelectWeaponLight();
            }
        }

        void ChoicerWeaponHeavy()
        {
            int previousSelectedWeaponHeavy = selectedWeaponHeavy;

            if (VirtualInputManager.Instance.SelectHeavyFire && Time.time > nextTimeToChangeWH)
            {
                Debug.Log("Heavy");
                if (selectedWeaponHeavy >= heavyWeaponCount - 1)
                {
                    selectedWeaponHeavy = 0;
                }
                else
                {
                    selectedWeaponHeavy++;
                }
                nextTimeToChangeWH = Time.time + ChoiceRateWH;
            }

            if (previousSelectedWeaponHeavy != selectedWeaponHeavy)
            {
                SelectWeaponHeavy();
            }
        }

        void SelectWeaponLight()
        {
            int i = 0;

            foreach(GameObject lightWeapon in lightWeapons)
            {
                if (i == selectedWeaponLight)
                {
                    lightWeapon.SetActive(true);
                }
                else
                {
                    lightWeapon.SetActive(false);
                }
                i++;
            }
        }

        void SelectWeaponHeavy()
        {
            int i = 0;

            foreach(GameObject heavyWeapon in heavyWeapons)
            {
                if (i == selectedWeaponHeavy)
                {
                    heavyWeapon.SetActive(true);
                }
                else
                {
                    heavyWeapon.SetActive(false);
                }
                i++;
            }
        }


    }
}

