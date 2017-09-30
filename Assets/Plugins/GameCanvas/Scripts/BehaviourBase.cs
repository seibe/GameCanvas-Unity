﻿/*------------------------------------------------------------*/
// <summary>GameCanvas for Unity</summary>
// <author>Seibe TAKAHASHI</author>
// <remarks>
// (c) 2015-2017 Smart Device Programming.
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
// </remarks>
/*------------------------------------------------------------*/

namespace GameCanvas
{
    using UnityEngine;
    using UnityEngine.Assertions;
    using GameCanvas.Engine;
    using GameCanvas.Input;
    using Collision = Engine.Collision;
    using Time = Engine.Time;

    [DisallowMultipleComponent]
    [RequireComponent(typeof(Camera), typeof(AudioListener), typeof(AudioSource))]
    public abstract class BehaviourBase : MonoBehaviour
    {
        //----------------------------------------------------------
        #region フィールド変数
        //----------------------------------------------------------

        [SerializeField]
        private int CanvasWidth = 720;
        [SerializeField]
        private int CanvasHeight = 1280;
        [SerializeField]
        private Resource Resource = null;

        private Camera mCamera;
        private AudioListener mListener;
        private AudioSource mAudioSource;

        private Time mTime;
        private Graphic mGraphic;
        private Sound mSound;
        private Collision mCollision;
        private Pointer mPointer;
        private Keyboard mKeyboard;
        private Accelerometer mAccelerometer;
        private Geolocation mGeolocation;
        private Proxy mProxy;

        #endregion

        //----------------------------------------------------------
        #region  Unity イベント関数
        //----------------------------------------------------------

        private void Awake()
        {
            mCamera = GetComponent<Camera>();
            mListener = GetComponent<AudioListener>();
            mAudioSource = GetComponent<AudioSource>();
            Assert.IsNotNull(mCamera);
            Assert.IsNotNull(mListener);
            Assert.IsNotNull(mAudioSource);
            Assert.IsNotNull(Resource);

            Resource.Initialize();

            mTime = new Time();
            mGraphic = new Graphic(Resource, mCamera);
            mGraphic.SetResolution(CanvasWidth, CanvasHeight);
            mSound = new Sound(Resource, mAudioSource);
            mCollision = new Collision(Resource);
            mPointer = new Pointer(mGraphic);
            mKeyboard = new Keyboard();
            mAccelerometer = new Accelerometer();
            mGeolocation = new Geolocation();
            mProxy = new Proxy(mTime, mGraphic, mSound, mCollision, mPointer, mKeyboard, mAccelerometer, mGeolocation);
        }

        private void Start()
        {
            InitGame();
        }

        private void Update()
        {
            mTime.OnBeforeUpdate();
            mGraphic.OnBeforeUpdate();
            mSound.OnBeforeUpdate();
            mPointer.OnBeforeUpdate();
            mKeyboard.OnBeforeUpdate();
            mAccelerometer.OnBeforeUpdate();
            mGeolocation.OnBeforeUpdate();

            UpdateGame();
            DrawGame();
        }

        private void OnApplicationFocus(bool focus)
        {
            // TODO
        }

        private void OnApplicationPause(bool pause)
        {
            // TODO
        }

        private void OnEnable()
        {
            mGraphic.OnEnable();
        }

        private void OnDisable()
        {
            mGraphic.OnDisable();
        }

        private void OnDestroy()
        {
            mGraphic.Dispose();
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (mGraphic != null) mGraphic.SetResolution(CanvasWidth, CanvasHeight);
        }
#endif //UNITY_EDITOR

        #endregion

        //----------------------------------------------------------
        #region パブリック関数 (Game.cs に公開している関数)
        //----------------------------------------------------------

        protected Proxy gc { get { return mProxy; } }

        public abstract void InitGame();

        public abstract void UpdateGame();

        public abstract void DrawGame();

        #endregion
    }
}
