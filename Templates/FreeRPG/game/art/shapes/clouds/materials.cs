//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton Material(cloudsbillboard_01_poofs)
{
	mapTo = "clouds";

	diffuseMap[0] = "art/shapes/clouds/poof_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/clouds/poof_normal.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = 1;
	translucent = 1;
	translucentBlendOp = "LerpAlpha";
   materialTag0 = "RoadAndPath";
};


//--- clouds_02.DAE MATERIALS BEGIN ---

//--- clouds_02.DAE MATERIALS END ---

