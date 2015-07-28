//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

// ENVIROMENTAL EFFECTS GO HERE (PRECIPITATION - LIGHTNING)

// ----------------------------------------------------------------------------
// Rain
// ----------------------------------------------------------------------------

datablock SFXProfile(HeavyRainSound)
{
   filename = "art/sound/environment/amb";
   description = AudioLoop2d;
};

datablock PrecipitationData(HeavyRain)
{
   soundProfile = "HeavyRainSound";

   dropTexture = "art/environment/precipitation/rain";
   splashTexture = "art/environment/precipitation/water_splash";
   dropSize = 0.35;
   splashSize = 0.1;
   useTrueBillboards = false;
   splashMS = 500;
};

// ----------------------------------------------------------------------------
// GroundFog
// ----------------------------------------------------------------------------


datablock PrecipitationData(groundFog)
{
   //soundProfile = "ADD SOUND HERE";

   dropTexture = "art/environment/precipitation/G_Fog";
   dropSize = 35;
   useTrueBillboards = false;
};

// ----------------------------------------------------------------------------
// Heavy Clouds
// ----------------------------------------------------------------------------


datablock PrecipitationData(HeavyCloud)
{
   //soundProfile = "ADD SOUND FILE HERE";

   dropTexture = "art/environment/precipitation/heavyCloud";
   dropSize = 1;
   useTrueBillboards = false;
};


// ----------------------------------------------------------------------------
// Snow
// ----------------------------------------------------------------------------


datablock PrecipitationData(snow)
{
   //soundProfile = "Ass sound File here";

   dropTexture = "art/environment/precipitation/snow";
   splashTexture = "art/environment/precipitation/snow";
   dropSize = 0.35;
   splashSize = 0.1;
   useTrueBillboards = false;
   splashMS = 500;
};

// ----------------------------------------------------------------------------
// Lightning
// ----------------------------------------------------------------------------

// When setting up thunder sounds for lightning it should be known that:
// - strikeSound is a 3d sound
// - thunderSounds[n] are 2d sounds

datablock SFXProfile(ThunderCrash1Sound)
{
   filename = "art/sound/environment/thunder1";
   description = Audio2d;
};

datablock SFXProfile(ThunderCrash2Sound)
{
   filename = "art/sound/environment/thunder2";
   description = Audio2d;
};

datablock SFXProfile(ThunderCrash3Sound)
{
   filename = "art/sound/environment/thunder3";
   description = Audio2d;
};

datablock SFXProfile(ThunderCrash4Sound)
{
   filename = "art/sound/environment/thunder4";
   description = Audio2d;
};

datablock LightningData(DefaultStorm)
{
   thunderSounds[0] = ThunderCrash1Sound;
   thunderSounds[1] = ThunderCrash2Sound;
   thunderSounds[2] = ThunderCrash3Sound;
   thunderSounds[3] = ThunderCrash4Sound;
};

//-JR
//Pacific Assets
// Electro-Tiki

datablock StaticShapeData( TikiData )
{
   category = "Misc";
   shapeFile = "art/shapes/props/electrotiki/electrotiki.DAE";
   isInvincible = true;
};

datablock LightFlareData( TikiLightFlare )
{
   overallScale = 2.0;
   flareEnabled = true;
   flareTexture = "art/datablocks/../special/lensFlareSheet1";
   
   elementRect[0] = "0 512 512 512";
   elementDist[0] = 0.0;
   elementScale[0] = 0.5;
   elementTint[0] = "0.5 0.5 0.5 1";
   elementRotate[0] = false;
   elementUseLightColor[0] = false;
   
   elementRect[1] = "512 0 512 512";
   elementDist[1] = 0.0;
   elementScale[1] = 1;
   elementTint[1] = "1 1 1 1";
   elementRotate[1] = false;
   elementUseLightColor[1] = false;
   occlusionRadius = "0.2";
};

function TikiData::onAdd( %this, %obj )
{
   echo( "TikiData::onadd" );
   
   %obj.playThread(0,"ambient");
   
   // This code was causing a crash when exiting from the editor
   // I removed it so we can ship. This will be addressed after
   // 1.1 final - MP
   /*
   %light = new PointLight()
   { 
      radius = 5;
      castShadows = false;
      flareScale = 0.6;
      flareType = "TikiLightFlare";
      isEnabled = false;
   };   

   %obj.mountObject( %light, 0 ); 
   if ( !isObject( DynamicLights ) )
      new SimSet( DynamicLights );     
   DynamicLights.add( %light );*/
}

// String-of-Lights

datablock StaticShapeData( StringOfLightsData )
{
   category = "Misc";
   shapeFile = "art/shapes/structures/hanginglights/hanginglights_animatedlights.dts";
   isInvincible = true;
};

datablock LightFlareData( StringOfLightsLightFlare )
{
   overallScale = 2.0;
   flareEnabled = true;
   flareTexture = "art/datablocks/../special/lensFlareSheet1";
   
   elementRect[0] = "0 512 512 512";
   elementDist[0] = 0.0;
   elementScale[0] = 0.5;
   elementTint[0] = "0.5 0.5 0.5 1";
   elementRotate[0] = false;
   elementUseLightColor[0] = false;
   
   elementRect[1] = "512 0 512 512";
   elementDist[1] = 0.0;
   elementScale[1] = 1;
   elementTint[1] = "0.4 0.4 0.4 1";
   elementRotate[1] = true;
   elementUseLightColor[1] = true;
   occlusionRadius = "0.2";
};

$hangingLightColors[0] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[1] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[2] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[3] = "0.996078 0.972549 0.662745 1";
$hangingLightColors[4] = "0.996078 0.972549 0.662745 1";

$hangingLightShadows[0] = false;
$hangingLightShadows[1] = false;
$hangingLightShadows[2] = false;
$hangingLightShadows[3] = false;
$hangingLightShadows[4] = false;

function StringOfLightsData::onAdd( %this, %obj )
{
   echo( "StringOfLightsData::onadd" );
   
   %obj.playThread(0,"ambient");
   
   // This code was causing a crash when exiting from the editor
   // I removed it so we can ship. This will be addressed after
   // 1.1 final - MP
   /* This was causing a crash
   for ( %i = 0; %i < 5; %i++ )
   {
      %light = new PointLight()
      { 
         radius = 7;
         brightness = 0.5;
         castShadows = $hangingLightShadows[%i];
         shadowType = "DualParaboloid";
         texSize = 256;
         shadowSoftness = 2;
         priority = 2;
         flareScale = 0.6;
         flareType = "StringOfLightsLightFlare";
         color = $hangingLightColors[%i];   
         isEnabled = false;      
      };   

      %obj.mountObject( %light, %i ); 
      if ( !isObject( DynamicLights ) )
         new SimSet( DynamicLights );     
      DynamicLights.add( %light );
   }*/
}

function Prefab::onLoad( %this, %grp )
{      
   echo( "Prefab::onLoad" );
   
   // Look for any lights in the SimGroup and add them to DynamicLights.
   
   if ( !isObject( DynamicLights ) )
      new SimSet( DynamicLights );     
      
   for ( %i = 0; %i < %grp.getCount(); %i++ )
   {
      %obj = %grp.getObject( %i );  
      if ( %obj.getClassName() $= "PointLight" )
         DynamicLights.add( %obj );  
   }   
}
//-JR
