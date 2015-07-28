//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------



singleton Material(concrete_pillars)
{
   mapTo = "concrete";  
   baseTex[0] = "";
   bumpTex[0] = "";

   pixelSpecular = 0;
   specular = "1 1 1 0";
   specularPower = 12;
   diffuseMap[0] = "art/shapes/structures/coveredstructure/concretepier_diffuse.dds";
   normalMap[0] = "art/shapes/structures/coveredstructure/concretepier_normal.dds";
   materialTag0 = "Structure";
   specularMap[0] = "art/shapes/structures/coveredstructure/concretepier_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};


singleton Material(coveredstructure_woodenroof)
{
	mapTo = "bluetinroof";

	diffuseMap[0] = "art/shapes/3TD_Studios/3td_Pallet_01/3td_PalletWood_01.jpg";

	diffuseColor[0] = "0.721569 0.721569 0.721569 1";
	specular[0] = "0.984314 0.984314 0.984314 1";
	specularPower[0] = 9;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   parallaxScale[0] = "0";
   pixelSpecular[0] = "0";
   materialTag0 = "Structure";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
};



//--- coveredstructure.dae MATERIALS BEGIN ---

//--- coveredstructure.dae MATERIALS END ---

