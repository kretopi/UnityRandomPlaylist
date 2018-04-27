/**
 * Copyright (c) 2018 Enzien Audio, Ltd.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice,
 *    this list of conditions, and the following disclaimer.
 * 
 * 2. Redistributions in binary form must reproduce the phrase "powered by heavy",
 *    the heavy logo, and a hyperlink to https://enzienaudio.com, all in a visible
 *    form.
 * 
 *   2.1 If the Application is distributed in a store system (for example,
 *       the Apple "App Store" or "Google Play"), the phrase "powered by heavy"
 *       shall be included in the app description or the copyright text as well as
 *       the in the app itself. The heavy logo will shall be visible in the app
 *       itself as well.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO,
 * THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 * THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Assertions;
using AOT;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(Hv_Playlist_AudioLib))]
public class Hv_Playlist_Editor : Editor {

  [MenuItem("Heavy/Playlist")]
  static void CreateHv_Playlist() {
    GameObject target = Selection.activeGameObject;
    if (target != null) {
      target.AddComponent<Hv_Playlist_AudioLib>();
    }
  }
  
  private Hv_Playlist_AudioLib _dsp;

  private void OnEnable() {
    _dsp = target as Hv_Playlist_AudioLib;
  }

  public override void OnInspectorGUI() {
    bool isEnabled = _dsp.IsInstantiated();
    if (!isEnabled) {
      EditorGUILayout.LabelField("Press Play!",  EditorStyles.centeredGreyMiniLabel);
    }
    // events
    GUI.enabled = isEnabled;
    EditorGUILayout.Space();
    // play
    if (GUILayout.Button("play")) {
      _dsp.SendEvent(Hv_Playlist_AudioLib.Event.Play);
    }
    
    GUILayout.EndVertical();

    // parameters
    GUI.enabled = true;
    GUILayout.BeginVertical();
    EditorGUILayout.Space();
    EditorGUI.indentLevel++;
    
    // track01length
    GUILayout.BeginHorizontal();
    float track01length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track01length);
    float newTrack01length = EditorGUILayout.Slider("track01length", track01length, 0.0f, 4410000.0f);
    if (track01length != newTrack01length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track01length, newTrack01length);
    }
    GUILayout.EndHorizontal();
    
    // track01vol
    GUILayout.BeginHorizontal();
    float track01vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track01vol);
    float newTrack01vol = EditorGUILayout.Slider("track01vol", track01vol, 0.0f, 1.0f);
    if (track01vol != newTrack01vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track01vol, newTrack01vol);
    }
    GUILayout.EndHorizontal();
    
    // track02length
    GUILayout.BeginHorizontal();
    float track02length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track02length);
    float newTrack02length = EditorGUILayout.Slider("track02length", track02length, 0.0f, 4410000.0f);
    if (track02length != newTrack02length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track02length, newTrack02length);
    }
    GUILayout.EndHorizontal();
    
    // track02vol
    GUILayout.BeginHorizontal();
    float track02vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track02vol);
    float newTrack02vol = EditorGUILayout.Slider("track02vol", track02vol, 0.0f, 1.0f);
    if (track02vol != newTrack02vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track02vol, newTrack02vol);
    }
    GUILayout.EndHorizontal();
    
    // track03length
    GUILayout.BeginHorizontal();
    float track03length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track03length);
    float newTrack03length = EditorGUILayout.Slider("track03length", track03length, 0.0f, 4410000.0f);
    if (track03length != newTrack03length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track03length, newTrack03length);
    }
    GUILayout.EndHorizontal();
    
    // track03vol
    GUILayout.BeginHorizontal();
    float track03vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track03vol);
    float newTrack03vol = EditorGUILayout.Slider("track03vol", track03vol, 0.0f, 1.0f);
    if (track03vol != newTrack03vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track03vol, newTrack03vol);
    }
    GUILayout.EndHorizontal();
    
    // track04length
    GUILayout.BeginHorizontal();
    float track04length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track04length);
    float newTrack04length = EditorGUILayout.Slider("track04length", track04length, 0.0f, 4410000.0f);
    if (track04length != newTrack04length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track04length, newTrack04length);
    }
    GUILayout.EndHorizontal();
    
    // track04vol
    GUILayout.BeginHorizontal();
    float track04vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track04vol);
    float newTrack04vol = EditorGUILayout.Slider("track04vol", track04vol, 0.0f, 1.0f);
    if (track04vol != newTrack04vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track04vol, newTrack04vol);
    }
    GUILayout.EndHorizontal();
    
    // track05length
    GUILayout.BeginHorizontal();
    float track05length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track05length);
    float newTrack05length = EditorGUILayout.Slider("track05length", track05length, 0.0f, 4410000.0f);
    if (track05length != newTrack05length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track05length, newTrack05length);
    }
    GUILayout.EndHorizontal();
    
    // track05vol
    GUILayout.BeginHorizontal();
    float track05vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track05vol);
    float newTrack05vol = EditorGUILayout.Slider("track05vol", track05vol, 0.0f, 1.0f);
    if (track05vol != newTrack05vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track05vol, newTrack05vol);
    }
    GUILayout.EndHorizontal();
    
    // track06length
    GUILayout.BeginHorizontal();
    float track06length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track06length);
    float newTrack06length = EditorGUILayout.Slider("track06length", track06length, 0.0f, 4410000.0f);
    if (track06length != newTrack06length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track06length, newTrack06length);
    }
    GUILayout.EndHorizontal();
    
    // track06vol
    GUILayout.BeginHorizontal();
    float track06vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track06vol);
    float newTrack06vol = EditorGUILayout.Slider("track06vol", track06vol, 0.0f, 1.0f);
    if (track06vol != newTrack06vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track06vol, newTrack06vol);
    }
    GUILayout.EndHorizontal();
    
    // track07length
    GUILayout.BeginHorizontal();
    float track07length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track07length);
    float newTrack07length = EditorGUILayout.Slider("track07length", track07length, 0.0f, 4410000.0f);
    if (track07length != newTrack07length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track07length, newTrack07length);
    }
    GUILayout.EndHorizontal();
    
    // track07vol
    GUILayout.BeginHorizontal();
    float track07vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track07vol);
    float newTrack07vol = EditorGUILayout.Slider("track07vol", track07vol, 0.0f, 1.0f);
    if (track07vol != newTrack07vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track07vol, newTrack07vol);
    }
    GUILayout.EndHorizontal();
    
    // track08length
    GUILayout.BeginHorizontal();
    float track08length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track08length);
    float newTrack08length = EditorGUILayout.Slider("track08length", track08length, 0.0f, 4410000.0f);
    if (track08length != newTrack08length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track08length, newTrack08length);
    }
    GUILayout.EndHorizontal();
    
    // track08vol
    GUILayout.BeginHorizontal();
    float track08vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track08vol);
    float newTrack08vol = EditorGUILayout.Slider("track08vol", track08vol, 0.0f, 1.0f);
    if (track08vol != newTrack08vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track08vol, newTrack08vol);
    }
    GUILayout.EndHorizontal();
    
    // track09length
    GUILayout.BeginHorizontal();
    float track09length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track09length);
    float newTrack09length = EditorGUILayout.Slider("track09length", track09length, 0.0f, 4410000.0f);
    if (track09length != newTrack09length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track09length, newTrack09length);
    }
    GUILayout.EndHorizontal();
    
    // track09vol
    GUILayout.BeginHorizontal();
    float track09vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track09vol);
    float newTrack09vol = EditorGUILayout.Slider("track09vol", track09vol, 0.0f, 1.0f);
    if (track09vol != newTrack09vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track09vol, newTrack09vol);
    }
    GUILayout.EndHorizontal();
    
    // track10length
    GUILayout.BeginHorizontal();
    float track10length = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track10length);
    float newTrack10length = EditorGUILayout.Slider("track10length", track10length, 0.0f, 4410000.0f);
    if (track10length != newTrack10length) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track10length, newTrack10length);
    }
    GUILayout.EndHorizontal();
    
    // track10vol
    GUILayout.BeginHorizontal();
    float track10vol = _dsp.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track10vol);
    float newTrack10vol = EditorGUILayout.Slider("track10vol", track10vol, 0.0f, 1.0f);
    if (track10vol != newTrack10vol) {
      _dsp.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track10vol, newTrack10vol);
    }
    GUILayout.EndHorizontal();
    EditorGUI.indentLevel--;
  }
}
#endif // UNITY_EDITOR

[RequireComponent (typeof (AudioSource))]
public class Hv_Playlist_AudioLib : MonoBehaviour {
  
  // Events are used to trigger bangs in the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_Playlist_AudioLib script = GetComponent<Hv_Playlist_AudioLib>();
        script.SendEvent(Hv_Playlist_AudioLib.Event.Play);
    }
  */
  public enum Event : uint {
    Play = 0xB49F32AB,
  }
  
  // Parameters are used to send float messages into the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_Playlist_AudioLib script = GetComponent<Hv_Playlist_AudioLib>();
        // Get and set a parameter
        float track01length = script.GetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track01length);
        script.SetFloatParameter(Hv_Playlist_AudioLib.Parameter.Track01length, track01length + 0.1f);
    }
  */
  public enum Parameter : uint {
    Track01length = 0x66AF5BC3,
    Track01vol = 0x7A6E90EB,
    Track02length = 0x56206859,
    Track02vol = 0xF5EA61D6,
    Track03length = 0x2F81E944,
    Track03vol = 0xE09B630F,
    Track04length = 0x2A523AFE,
    Track04vol = 0xA9B2C5AF,
    Track05length = 0xC0E065B3,
    Track05vol = 0x11BC3C45,
    Track06length = 0x5E286648,
    Track06vol = 0xAD57985E,
    Track07length = 0x47515725,
    Track07vol = 0x791AA938,
    Track08length = 0xDAE98771,
    Track08vol = 0x702E5963,
    Track09length = 0xCA04F011,
    Track09vol = 0x45340733,
    Track10length = 0xB25B323C,
    Track10vol = 0x6D5C844D,
  }
  
  // Delegate method for receiving float messages from the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_Playlist_AudioLib script = GetComponent<Hv_Playlist_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_Playlist_AudioLib.FloatMessage message) {
        Debug.Log(message.receiverName + ": " + message.value);
    }
  */
  public class FloatMessage {
    public string receiverName;
    public float value;

    public FloatMessage(string name, float x) {
      receiverName = name;
      value = x;
    }
  }
  public delegate void FloatMessageReceived(FloatMessage message);
  public FloatMessageReceived FloatReceivedCallback;
  public float track01length = 0.0f;
  public float track01vol = 0.5f;
  public float track02length = 0.0f;
  public float track02vol = 0.5f;
  public float track03length = 0.0f;
  public float track03vol = 0.5f;
  public float track04length = 0.0f;
  public float track04vol = 0.5f;
  public float track05length = 0.0f;
  public float track05vol = 0.5f;
  public float track06length = 0.0f;
  public float track06vol = 0.5f;
  public float track07length = 0.0f;
  public float track07vol = 0.5f;
  public float track08length = 0.0f;
  public float track08vol = 0.5f;
  public float track09length = 0.0f;
  public float track09vol = 0.5f;
  public float track10length = 0.0f;
  public float track10vol = 0.5f;

  // internal state
  private Hv_Playlist_Context _context;

  public bool IsInstantiated() {
    return (_context != null);
  }

  public void RegisterSendHook() {
    _context.RegisterSendHook();
  }
  
  // see Hv_Playlist_AudioLib.Event for definitions
  public void SendEvent(Hv_Playlist_AudioLib.Event e) {
    if (IsInstantiated()) _context.SendBangToReceiver((uint) e);
  }
  
  // see Hv_Playlist_AudioLib.Parameter for definitions
  public float GetFloatParameter(Hv_Playlist_AudioLib.Parameter param) {
    switch (param) {
      case Parameter.Track01length: return track01length;
      case Parameter.Track01vol: return track01vol;
      case Parameter.Track02length: return track02length;
      case Parameter.Track02vol: return track02vol;
      case Parameter.Track03length: return track03length;
      case Parameter.Track03vol: return track03vol;
      case Parameter.Track04length: return track04length;
      case Parameter.Track04vol: return track04vol;
      case Parameter.Track05length: return track05length;
      case Parameter.Track05vol: return track05vol;
      case Parameter.Track06length: return track06length;
      case Parameter.Track06vol: return track06vol;
      case Parameter.Track07length: return track07length;
      case Parameter.Track07vol: return track07vol;
      case Parameter.Track08length: return track08length;
      case Parameter.Track08vol: return track08vol;
      case Parameter.Track09length: return track09length;
      case Parameter.Track09vol: return track09vol;
      case Parameter.Track10length: return track10length;
      case Parameter.Track10vol: return track10vol;
      default: return 0.0f;
    }
  }

  public void SetFloatParameter(Hv_Playlist_AudioLib.Parameter param, float x) {
    switch (param) {
      case Parameter.Track01length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track01length = x;
        break;
      }
      case Parameter.Track01vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track01vol = x;
        break;
      }
      case Parameter.Track02length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track02length = x;
        break;
      }
      case Parameter.Track02vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track02vol = x;
        break;
      }
      case Parameter.Track03length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track03length = x;
        break;
      }
      case Parameter.Track03vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track03vol = x;
        break;
      }
      case Parameter.Track04length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track04length = x;
        break;
      }
      case Parameter.Track04vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track04vol = x;
        break;
      }
      case Parameter.Track05length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track05length = x;
        break;
      }
      case Parameter.Track05vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track05vol = x;
        break;
      }
      case Parameter.Track06length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track06length = x;
        break;
      }
      case Parameter.Track06vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track06vol = x;
        break;
      }
      case Parameter.Track07length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track07length = x;
        break;
      }
      case Parameter.Track07vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track07vol = x;
        break;
      }
      case Parameter.Track08length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track08length = x;
        break;
      }
      case Parameter.Track08vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track08vol = x;
        break;
      }
      case Parameter.Track09length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track09length = x;
        break;
      }
      case Parameter.Track09vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track09vol = x;
        break;
      }
      case Parameter.Track10length: {
        x = Mathf.Clamp(x, 0.0f, 4410000.0f);
        track10length = x;
        break;
      }
      case Parameter.Track10vol: {
        x = Mathf.Clamp(x, 0.0f, 1.0f);
        track10vol = x;
        break;
      }
      default: return;
    }
    if (IsInstantiated()) _context.SendFloatToReceiver((uint) param, x);
  }
  
  public void FillTableWithMonoAudioClip(string tableName, AudioClip clip) {
    if (clip.channels > 1) {
      Debug.LogWarning("Hv_Playlist_AudioLib: Only loading first channel of '" +
          clip.name + "' into table '" +
          tableName + "'. Multi-channel files are not supported.");
    }
    float[] buffer = new float[clip.samples]; // copy only the 1st channel
    clip.GetData(buffer, 0);
    _context.FillTableWithFloatBuffer(tableName, buffer);
  }

  public void FillTableWithFloatBuffer(string tableName, float[] buffer) {
    _context.FillTableWithFloatBuffer(tableName, buffer);
  }

  private void Awake() {
    _context = new Hv_Playlist_Context((double) AudioSettings.outputSampleRate);
  }
  
  private void Start() {
    _context.SendFloatToReceiver((uint) Parameter.Track01length, track01length);
    _context.SendFloatToReceiver((uint) Parameter.Track01vol, track01vol);
    _context.SendFloatToReceiver((uint) Parameter.Track02length, track02length);
    _context.SendFloatToReceiver((uint) Parameter.Track02vol, track02vol);
    _context.SendFloatToReceiver((uint) Parameter.Track03length, track03length);
    _context.SendFloatToReceiver((uint) Parameter.Track03vol, track03vol);
    _context.SendFloatToReceiver((uint) Parameter.Track04length, track04length);
    _context.SendFloatToReceiver((uint) Parameter.Track04vol, track04vol);
    _context.SendFloatToReceiver((uint) Parameter.Track05length, track05length);
    _context.SendFloatToReceiver((uint) Parameter.Track05vol, track05vol);
    _context.SendFloatToReceiver((uint) Parameter.Track06length, track06length);
    _context.SendFloatToReceiver((uint) Parameter.Track06vol, track06vol);
    _context.SendFloatToReceiver((uint) Parameter.Track07length, track07length);
    _context.SendFloatToReceiver((uint) Parameter.Track07vol, track07vol);
    _context.SendFloatToReceiver((uint) Parameter.Track08length, track08length);
    _context.SendFloatToReceiver((uint) Parameter.Track08vol, track08vol);
    _context.SendFloatToReceiver((uint) Parameter.Track09length, track09length);
    _context.SendFloatToReceiver((uint) Parameter.Track09vol, track09vol);
    _context.SendFloatToReceiver((uint) Parameter.Track10length, track10length);
    _context.SendFloatToReceiver((uint) Parameter.Track10vol, track10vol);
  }
  
  private void Update() {
    // retreive sent messages
    if (_context.IsSendHookRegistered()) {
      Hv_Playlist_AudioLib.FloatMessage tempMessage;
      while ((tempMessage = _context.msgQueue.GetNextMessage()) != null) {
        FloatReceivedCallback(tempMessage);
      }
    }
  }

  private void OnAudioFilterRead(float[] buffer, int numChannels) {
    Assert.AreEqual(numChannels, _context.GetNumOutputChannels()); // invalid channel configuration
    _context.Process(buffer, buffer.Length / numChannels); // process dsp
  }
}

class Hv_Playlist_Context {

#if UNITY_IOS && !UNITY_EDITOR
  private const string _dllName = "__Internal";
#else
  private const string _dllName = "Hv_Playlist_AudioLib";
#endif

  // Thread-safe message queue
  public class SendMessageQueue {
    private readonly object _msgQueueSync = new object();
    private readonly Queue<Hv_Playlist_AudioLib.FloatMessage> _msgQueue = new Queue<Hv_Playlist_AudioLib.FloatMessage>();

    public Hv_Playlist_AudioLib.FloatMessage GetNextMessage() {
      lock (_msgQueueSync) {
        return (_msgQueue.Count != 0) ? _msgQueue.Dequeue() : null;
      }
    }

    public void AddMessage(string receiverName, float value) {
      Hv_Playlist_AudioLib.FloatMessage msg = new Hv_Playlist_AudioLib.FloatMessage(receiverName, value);
      lock (_msgQueueSync) {
        _msgQueue.Enqueue(msg);
      }
    }
  }

  public readonly SendMessageQueue msgQueue = new SendMessageQueue();
  private readonly GCHandle gch;
  private readonly IntPtr _context; // handle into unmanaged memory
  private SendHook _sendHook = null;

  [DllImport (_dllName)]
  private static extern IntPtr hv_Playlist_new_with_options(double sampleRate, int poolKb, int inQueueKb, int outQueueKb);

  [DllImport (_dllName)]
  private static extern int hv_processInlineInterleaved(IntPtr ctx,
      [In] float[] inBuffer, [Out] float[] outBuffer, int numSamples);

  [DllImport (_dllName)]
  private static extern void hv_delete(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern double hv_getSampleRate(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumInputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumOutputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_setSendHook(IntPtr ctx, SendHook sendHook);

  [DllImport (_dllName)]
  private static extern void hv_setPrintHook(IntPtr ctx, PrintHook printHook);

  [DllImport (_dllName)]
  private static extern int hv_setUserData(IntPtr ctx, IntPtr userData);

  [DllImport (_dllName)]
  private static extern IntPtr hv_getUserData(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_sendBangToReceiver(IntPtr ctx, uint receiverHash);

  [DllImport (_dllName)]
  private static extern void hv_sendFloatToReceiver(IntPtr ctx, uint receiverHash, float x);

  [DllImport (_dllName)]
  private static extern uint hv_msg_getTimestamp(IntPtr message);

  [DllImport (_dllName)]
  private static extern bool hv_msg_hasFormat(IntPtr message, string format);

  [DllImport (_dllName)]
  private static extern float hv_msg_getFloat(IntPtr message, int index);

  [DllImport (_dllName)]
  private static extern bool hv_table_setLength(IntPtr ctx, uint tableHash, uint newSampleLength);

  [DllImport (_dllName)]
  private static extern IntPtr hv_table_getBuffer(IntPtr ctx, uint tableHash);

  [DllImport (_dllName)]
  private static extern float hv_samplesToMilliseconds(IntPtr ctx, uint numSamples);

  [DllImport (_dllName)]
  private static extern uint hv_stringToHash(string s);

  private delegate void PrintHook(IntPtr context, string printName, string str, IntPtr message);

  private delegate void SendHook(IntPtr context, string sendName, uint sendHash, IntPtr message);

  public Hv_Playlist_Context(double sampleRate, int poolKb=10, int inQueueKb=20, int outQueueKb=2) {
    gch = GCHandle.Alloc(msgQueue);
    _context = hv_Playlist_new_with_options(sampleRate, poolKb, inQueueKb, outQueueKb);
    hv_setPrintHook(_context, new PrintHook(OnPrint));
    hv_setUserData(_context, GCHandle.ToIntPtr(gch));
  }

  ~Hv_Playlist_Context() {
    hv_delete(_context);
    GC.KeepAlive(_context);
    GC.KeepAlive(_sendHook);
    gch.Free();
  }

  public void RegisterSendHook() {
    // Note: send hook functionality only applies to messages containing a single float value
    if (_sendHook == null) {
      _sendHook = new SendHook(OnMessageSent);
      hv_setSendHook(_context, _sendHook);
    }
  }

  public bool IsSendHookRegistered() {
    return (_sendHook != null);
  }

  public double GetSampleRate() {
    return hv_getSampleRate(_context);
  }

  public int GetNumInputChannels() {
    return hv_getNumInputChannels(_context);
  }

  public int GetNumOutputChannels() {
    return hv_getNumOutputChannels(_context);
  }

  public void SendBangToReceiver(uint receiverHash) {
    hv_sendBangToReceiver(_context, receiverHash);
  }

  public void SendFloatToReceiver(uint receiverHash, float x) {
    hv_sendFloatToReceiver(_context, receiverHash, x);
  }

  public void FillTableWithFloatBuffer(string tableName, float[] buffer) {
    uint tableHash = hv_stringToHash(tableName);
    if (hv_table_getBuffer(_context, tableHash) != IntPtr.Zero) {
      hv_table_setLength(_context, tableHash, (uint) buffer.Length);
      Marshal.Copy(buffer, 0, hv_table_getBuffer(_context, tableHash), buffer.Length);
    } else {
      Debug.Log(string.Format("Table '{0}' doesn't exist in the patch context.", tableName));
    }
  }

  public uint StringToHash(string s) {
    return hv_stringToHash(s);
  }

  public int Process(float[] buffer, int numFrames) {
    return hv_processInlineInterleaved(_context, buffer, buffer, numFrames);
  }

  [MonoPInvokeCallback(typeof(PrintHook))]
  private static void OnPrint(IntPtr context, string printName, string str, IntPtr message) {
    float timeInSecs = hv_samplesToMilliseconds(context, hv_msg_getTimestamp(message)) / 1000.0f;
    Debug.Log(string.Format("{0} [{1:0.000}]: {2}", printName, timeInSecs, str));
  }

  [MonoPInvokeCallback(typeof(SendHook))]
  private static void OnMessageSent(IntPtr context, string sendName, uint sendHash, IntPtr message) {
    if (hv_msg_hasFormat(message, "f")) {
      SendMessageQueue msgQueue = (SendMessageQueue) GCHandle.FromIntPtr(hv_getUserData(context)).Target;
      msgQueue.AddMessage(sendName, hv_msg_getFloat(message, 0));
    }
  }
}
