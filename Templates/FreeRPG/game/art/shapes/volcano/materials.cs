//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- volcano.DAE MATERIALS BEGIN ---
singleton Material(volcano_tex_volcano_cave_2)
{
	mapTo = "tex_volcano_cave_2";

	diffuseMap[0] = "art/shapes/volcano/volcano_cave_2_dif";
	normalMap[0] = "art/shapes/volcano/volcano_cave_2_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   detailMap[0] = "art/shapes/volcano/volcano_cave_wall_tileable.dds";
   detailScale[0] = "3 3";
};

singleton Material(volcano_tex_volcano_cave_3)
{
	mapTo = "tex_volcano_cave_3";

	diffuseMap[0] = "art/shapes/volcano/volcano_cave_3_dif";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   detailMap[0] = "art/terrains/rocky dirt/rockydirt_detail.png";
   detailScale[0] = "12 12";
   detailNormalMap[0] = "art/terrains/rocky dirt/rockydirt_normal.png";
};

singleton Material(volcano_tex_volcano_cave_3)
{
	mapTo = "tex_volcano_cave_3";

	diffuseMap[0] = "volcano_cave_3_dif";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- volcano.DAE MATERIALS END ---


singleton Material(volcano_tex_volcano_cave_1)
{
   mapTo = "tex_volcano_cave_1";
   diffuseMap[0] = "art/shapes/volcano/volcano_cave_1_dif.dds";
   detailScale[0] = "6 6";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   detailMap[0] = "art/shapes/volcano/volcano_cave_wall_tileable.dds";
   normalMap[0] = "art/shapes/volcano/volcano_cave_1_nrm.dds";
};

singleton Material(volcano_lavaflow)
{
	mapTo = "lavaflow_material";

	diffuseMap[0] = "art/shapes/volcano/lava_denser_diffuse.png";
	normalMap[0] = "art/shapes/volcano/lava_denser_normal_disp.png";
	specularMap[0] = "art/shapes/volcano/lava_denser_specular.png";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.00784314 0.996078 0.00784314 1";
	specularPower[0] = "34";

	doubleSided = false;
	translucent = "0";
	translucentBlendOp = "Mul";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "-1 0";
   scrollSpeed[0] = "0.01";
   emissive[0] = "0";
   castShadows = "0";
   materialTag0 = "RoadAndPath";
   parallaxScale[0] = "0.0138889";
   pixelSpecular[0] = "0";
   alphaRef = "80";
   glow[1] = "1";
   forestWindEnabled = "1";
   backlight = "1";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
};
//--- lavaglow.DAE MATERIALS BEGIN ---
singleton Material(lavaglow_ColorEffectR6G135B113_material)
{
	mapTo = "ColorEffectR6G135B113-material";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.0235294 0.529412 0.443137 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(lavaglow)
{
	mapTo = "lavaglow";

	diffuseMap[0] = "art/shapes/volcano/lavaglow_diffuse";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = "1";
	translucentBlendOp = "Add";
   glow[0] = "1";
   backlight = "1";
   materialTag0 = "RoadAndPath";
   backLightFactor = "0.9 1.0 0.2";
   materialTag1 = "Vegetation";
   forestWindEnabled = "1";
   emissive[0] = "1";
   castShadows = "0";
};

