using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HUX.Focus;
using HUX.Interaction;
using HUX.Receivers;

namespace HUX
{
    public class ButtonsController : InteractionReceiver
    {
        public GameObject TextObjectState;
        public TextMesh txt;

        // Use this for initialization
        void Start()
        {
            txt = TextObjectState.GetComponentInChildren<TextMesh>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnTapped(GameObject obj, InteractionManager.InteractionEventArgs eventArgs)
        {
            txt.text = obj.name + " : OnTapped";

            switch (obj.name)
            {
                case "SpecialRouteButtonHolographic":
                    // Do something on ButtonHolographic:OnTapped
                    break;
                case "JustStartButtonHolographic":
                    // Do something on ButtonHolographic:OnTapped
                    break;
                case "ProfesionalRouteButtonHolographic":
                    // Do something on ButtonHolographic:OnTapped
                    break;
            }
            base.OnTapped(obj, eventArgs);
        }
    }
}