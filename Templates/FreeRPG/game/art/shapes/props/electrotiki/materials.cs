//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

//--- electrotiki.DAE MATERIALS BEGIN ---
singleton Material(electrotiki_electrotikibulb)
{
	mapTo = "electrotikibulb";

	diffuseMap[0] = "art/shapes/props/electrotiki/electrotikibulb_diffuse.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 0.502";
	specular[0] = "0.992157 0.992157 0.992157 1";
	specularPower[0] = "8";

	doubleSided = "1";
	translucent = 1;
	translucentBlendOp = "LerpAlpha";
   castShadows = "0";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   materialTag0 = "Structure";
   backlight = "1";
   detailScale[0] = "20 20";
   detailNormalMapStrength[0] = "15";
   pixelSpecular[0] = "1";
   alphaRef = "0";
   cubemap = "NewLevelSkyCubemap";
   effectColor[0] = "0.317647 0.317647 0.317647 0";
};

//--- electrotiki.DAE MATERIALS END ---


singleton Material(electrotiki_electrotikimaterial)
{
   mapTo = "electrotikimaterial";
   diffuseMap[0] = "art/shapes/props/electrotiki/electrotiki_diffuse.dds";
   normalMap[0] = "art/shapes/props/electrotiki/electrotiki_normals.dds";
   doubleSided = "1";
   translucentBlendOp = "None";
   specularMap[0] = "art/shapes/props/electrotiki/electrotiki_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   materialTag0 = "Structure";
   backlight = "1";
   castShadows = "0";
};
