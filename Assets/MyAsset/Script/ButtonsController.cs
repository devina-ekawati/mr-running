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

        public Sprite SpecialRouteButtonClicked, SpecialRouteButtonDefault;
        public Sprite JustStartButtonClicked, JustStartButtonDefault;
        public Sprite ProfessionalButtonClicked, ProfessionalButtonDefault;

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
                case "SpecialRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SpecialRouteButtonClicked;
                    break;
                case "JustStartButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = JustStartButtonClicked;
                    break;
                case "ProfessionalRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = ProfessionalButtonClicked;
                    break;
            }

            base.OnTapped(obj, eventArgs);
        }

        protected override void OnHoldStarted(GameObject obj, InteractionManager.InteractionEventArgs eventArgs)
        {
            txt.text = obj.name + " : OnHoldStarted";

            switch (obj.name)
            {
                case "SpecialRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SpecialRouteButtonClicked;
                    break;
                case "JustStartButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = JustStartButtonClicked;
                    break;
                case "ProfessionalRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = ProfessionalButtonClicked;
                    break;
            }

            base.OnHoldStarted(obj, eventArgs);
        }

        protected override void OnFocusEnter(GameObject obj, FocusArgs args)
        {
            txt.text = obj.name + " : OnFocusEnter";

            switch (obj.name)
            {
                case "SpecialRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SpecialRouteButtonClicked;
                    break;
                case "JustStartButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = JustStartButtonClicked;
                    break;
                case "ProfessionalRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = ProfessionalButtonClicked;
                    break;
            }

            base.OnFocusEnter(obj, args);
        }

        protected override void OnFocusExit(GameObject obj, FocusArgs args)
        {
            txt.text = obj.name + " : OnFocusExit";

            switch (obj.name)
            {
                case "SpecialRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SpecialRouteButtonDefault;
                    break;
                case "JustStartButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = JustStartButtonDefault;
                    break;
                case "ProfessionalRouteButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = ProfessionalButtonDefault;
                    break;
            }

            base.OnFocusExit(obj, args);
        }
    }
}