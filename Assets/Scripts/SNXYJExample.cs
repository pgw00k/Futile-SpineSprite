using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;

public class SNXYJExample : MonoBehaviour
{

    private GSpineSprite sprite;

    private Vector2 _scrollPosition;

    void Start()
    {

        // Setup Futile
        FutileParams fparams = new FutileParams(true, true, true, true);
        fparams.AddResolutionLevel(1024.0f, 1.0f, 1.0f, "");
        fparams.origin = new Vector2(0.5f, 0.5f);
        Futile.instance.Init(fparams);


        GSpineManager.LoadSpineBySkel("990001", "spine/990001/990001.skel.bytes", "spine/990001/990001.atlas");
        sprite = new GSpineSprite("990001");
        Futile.stage.AddChild(sprite);
        sprite.SetPosition((Futile.screen.halfWidth * 0.25f), -(Futile.screen.halfHeight * 0.5f));
        sprite.scale = 0.5f;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
