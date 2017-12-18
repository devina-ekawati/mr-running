using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HUX.Focus;
using HUX.Interaction;
using HUX.Receivers;

namespace HUX
{
    public class LoginController : InteractionReceiver
    {

        public Sprite LoginButtonClicked, LoginButtonDefault;
        public Sprite SignUpButtonClicked, SignUpButtonDefault;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnTapped(GameObject obj, InteractionManager.InteractionEventArgs eventArgs)
        {

            switch (obj.name)
            {
                case "LoginButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = LoginButtonClicked;
                    break;
                case "SignUpButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SignUpButtonClicked;
                    break;
            }

            base.OnTapped(obj, eventArgs);
        }

        protected override void OnHoldStarted(GameObject obj, InteractionManager.InteractionEventArgs eventArgs)
        {

            switch (obj.name)
            {
                case "LoginButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = LoginButtonClicked;
                    break;
                case "SignUpButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SignUpButtonClicked;
                    break;
            }

            base.OnHoldStarted(obj, eventArgs);
        }

        protected override void OnFocusEnter(GameObject obj, FocusArgs args)
        {

            switch (obj.name)
            {
                case "LoginButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = LoginButtonClicked;
                    break;
                case "SignUpButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SignUpButtonClicked;
                    break;
            }

            base.OnFocusEnter(obj, args);
        }

        protected override void OnFocusExit(GameObject obj, FocusArgs args)
        {

            switch (obj.name)
            {
                case "LoginButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = LoginButtonDefault;
                    break;
                case "SignUpButton":
                    obj.GetComponentInChildren<SpriteRenderer>().sprite = SignUpButtonDefault;
                    break;
            }

            base.OnFocusExit(obj, args);
        }
    }
}

