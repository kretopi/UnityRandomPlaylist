using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playlist : MonoBehaviour {
	public AudioClip track1;
	public AudioClip track2;
	public AudioClip track3;
	public AudioClip track4;
	public AudioClip track5;
	public AudioClip track6;
	public AudioClip track7;
	public AudioClip track8;
	public AudioClip track9;
	public AudioClip track10;

	private Hv_Playlist_AudioLib playlist;



	// Use this for initialization
	void Start () {
		playlist = GetComponent<Hv_Playlist_AudioLib> ();

		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track01length, track1.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track02length, track2.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track03length, track3.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track04length, track4.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track05length, track5.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track06length, track6.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track07length, track7.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track08length, track8.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track09length, track9.samples);
		playlist.SetFloatParameter (Hv_Playlist_AudioLib.Parameter.Track10length, track10.samples);

		playlist.FillTableWithMonoAudioClip ("track01", track1);
		playlist.FillTableWithMonoAudioClip ("track02", track2);
		playlist.FillTableWithMonoAudioClip ("track03", track3);
		playlist.FillTableWithMonoAudioClip ("track04", track4);
		playlist.FillTableWithMonoAudioClip ("track05", track5);
		playlist.FillTableWithMonoAudioClip ("track06", track6);
		playlist.FillTableWithMonoAudioClip ("track07", track7);
		playlist.FillTableWithMonoAudioClip ("track08", track8);
		playlist.FillTableWithMonoAudioClip ("track09", track9);
		playlist.FillTableWithMonoAudioClip ("track10", track10);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
