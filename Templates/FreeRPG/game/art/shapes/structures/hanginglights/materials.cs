//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(hanginglightsbulb_material)
{
   diffuseMap[0] = "art/shapes/structures/hanginglights/hanginglightsbulb_diffuse.dds";
   emissive = true;
   mapTo = "hanginglightsbulb_diffuse";
   translucent = "1";
   materialTag0 = "Prop";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};


singleton Material(hanginglights_material)
{
   mapTo = "hanginglightspostmaterial";
   diffuseMap[0] = "art/shapes/structures/hanginglights/hanginglights_diffuse.dds";
   normalMap[0] = "art/shapes/structures/hanginglights/hanginglights_normal.dds";
   materialTag0 = "Prop";
   specularMap[0] = "art/shapes/structures/hanginglights/hanginglights_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};
//--- hanginglightspost.DAE MATERIALS BEGIN ---

//--- hanginglightspost.DAE MATERIALS END ---

//--- hanginglights_lights.DAE MATERIALS BEGIN ---
singleton Material(hanginglights_lights__01___Default)
{
	mapTo = "_01___Default";

	diffuseMap[0] = "hanginglights_diffuse";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0 0 0 1";
	specularPower[0] = 2;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- hanginglights_lights.DAE MATERIALS END ---


singleton Material(hanginglightspost_hanginglights_cord)
{
   mapTo = "hanginglights_cord";
   diffuseMap[0] = "hanginglights_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(hanginglightspost_ColorEffectR6G135B58_material)
{
   mapTo = "ColorEffectR6G135B58-material";
   diffuseColor[0] = "0.0235294 0.529412 0.227451 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
