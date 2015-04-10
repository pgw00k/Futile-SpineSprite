using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Spine;

public class SpineboySpacemanExample : MonoBehaviour {

	private GSpineSprite sprite;
	
	private Vector2 _scrollPosition;
	
	void Start(){

		// Setup Futile
		FutileParams fparams = new FutileParams(true, true, true, true);
		fparams.AddResolutionLevel(1024.0f,	1.0f, 1.0f, "");
		fparams.origin = new Vector2(0.5f,0.5f);
		Futile.instance.Init(fparams);
		

		GSpineManager.LoadSpine("spineboy-spaceman", "spine/spineboy-spaceman/spineboy-spaceman-spine", "spine/spineboy-spaceman/spineboy-spaceman-atlas");
		sprite = new GSpineSprite("spineboy-spaceman");
		Futile.stage.AddChild(sprite);
		sprite.SetPosition((Futile.screen.halfWidth * 0.25f), -(Futile.screen.halfHeight * 0.5f));
		sprite.scale = 0.5f;
		sprite.Play("idle");
		sprite.SetAnimationMix("jump", "idle", 0.4f);
		sprite.SetAnimationMix("hit", "idle", 0.4f);
		sprite.SetAnimationMix("shoot", "idle", 0.4f);
	}
	
	
	void OnGUI() {
		GUI.skin.button.fixedWidth = 200;
		GUILayout.BeginArea(new Rect(0, 0, GUI.skin.button.fixedWidth + 25, Screen.height));
		_scrollPosition = GUILayout.BeginScrollView(_scrollPosition, GUILayout.Width(GUI.skin.button.fixedWidth + 25), GUILayout.Height(Screen.height));
		

		if(GUILayout.Button("Goblins Example")){
			Application.LoadLevel("GoblinsExample");
		}
		if(GUILayout.Button("Powerup Example")){
			Application.LoadLevel("PowerupExample");
		}
		if(GUILayout.Button("Spineboy Original Example")){
			Application.LoadLevel("SpineboyOriginalExample");
		}
		if(GUILayout.Button("Spineboy Spaceman Example")){
			Application.LoadLevel("SpineboySpacemanExample");
		}


		if(GUILayout.Button("Play Animation")){
			sprite.Play("walk");
		}
		if(GUILayout.Button("Pause Animation")){
			sprite.Pause();
		}
		if(GUILayout.Button("Resume Animation")){
			sprite.Resume();
		}
		if(GUILayout.Button("Stop Animation")){
			sprite.Stop();
		}
		

		if(GUILayout.Button("Slow Motion")){
			sprite.SetAnimationTimeScale(0.5f);
		}
		if(GUILayout.Button("Normal Speed")){
			sprite.SetAnimationTimeScale(1.0f);
		}


		if(GUILayout.Button("Idle Animation")){
			sprite.Play("idle", true);
		}
		if(GUILayout.Button("Walk Animation")){
			sprite.Play("walk", true);
		}
		if(GUILayout.Button("Run Animation")){
			sprite.Play("run", true);
		}
		if(GUILayout.Button("Jump Animation")){
			sprite.Play("jump", false);
			sprite.Queue("idle");
		}
		if(GUILayout.Button("Hit Animation")){
			sprite.Play("hit", false);
			sprite.Queue("idle");
		}
		if(GUILayout.Button("Shoot Animation")){
			sprite.Play("shoot", false);
			sprite.Queue("idle");
		}
		if(GUILayout.Button("Death Animation")){
			sprite.Play("death", false);
		}


		if(GUILayout.Button("Tint Blue")){
			sprite.color = Color.blue;
		}
		if(GUILayout.Button("Clear Tint")){
			sprite.color = Color.white;
		}
		

		if(GUILayout.Button("Scale sprite 2x")){
			sprite.scale = 2.0f;
		}
		if(GUILayout.Button("Scale sprite 0.5x")){
			sprite.scale = 0.5f;	
		}
		if(GUILayout.Button("Reset Scale")){
			sprite.scale = 1.0f;
		}


		if(GUILayout.Button("Rotate sprite 45deg")){
			sprite.rotation -= 45.0f;
		}
		if(GUILayout.Button("Reset rotation")){
			sprite.rotation = 0.0f;
		}


		if(GUILayout.Button("Flip X")){
			sprite.flipX = !sprite.flipX;
		}
		if(GUILayout.Button("Flip Y")){
			sprite.flipY = !sprite.flipY;
		}
		
		
		GUILayout.EndScrollView();
		GUILayout.EndArea();
    }
}













	