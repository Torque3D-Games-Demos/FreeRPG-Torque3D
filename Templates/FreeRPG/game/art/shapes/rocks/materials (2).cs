//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------



// GRAYROCK -----------------------------------------------------------------------


singleton Material(greyrock_material)
{

   mapTo = "greyrock";  
   diffuseMap[0] = "art/shapes/rocks/grayrock_diffuse.dds";
   normalMap[0] = "art/shapes/rocks/grayrock_normal.dds";

   pixelSpecular[0] = 0;
   specular[0] = "1 1 1 0";
   specularPower [0] = 12;
   specularPower[0] = "49";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   detailScale[0] = "20 20";
   detailNormalMap[0] = "art/shapes/rocks/grayrock_detailnormal.dds";
   detailNormalMapStrength[0] = "0.1";
   materialTag0 = "Rock";
   diffuseColor[0] = "0.996078 0.996078 0.996078 1";
   specularMap[0] = "art/shapes/rocks/grayrock_specular.dds";

//   detailTex[0] = "grayrock_detail.dds";
//   detailScale[0] = "25 25";

};



//GRAYROCK - HIGHNORMS -----------------------------------------------------------



singleton Material(greyrock_highnorms_material)
{

   mapTo = "greyrock_highnorms";  
   diffuseMap[0] = "art/shapes/rocks/grayrock_diffuse.dds";
   normalMap[0] = "art/shapes/rocks/grayrock_normal.dds";

   pixelSpecular[0] = 0;
   specular[0] = "1 1 1 0";
   specularPower [0] = 12;
   specularPower[0] = "1";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   detailScale[0] = "2 2";
   detailNormalMap[0] = "art/shapes/rocks/grayrock_detailnormal.dds";
   detailNormalMapStrength[0] = "0.5";
   materialTag0 = "Rock";
   specularMap[0] = "art/shapes/rocks/grayrock_specular.dds";

//   detailTex[0] = "grayrock_detail.dds";
//   detailScale[0] = "25 25";

};




//UNDERWATER ROCKS -------------------------------------------------------------



singleton Material(_20_smallrocksix_tex_underwater_rock)
{
	mapTo = "tex_underwater_rock";

	diffuseMap[0] = "art/shapes/rocks/tex_rock_underwater_dif.dds";
	normalMap[0] = "art/shapes/rocks/tex_rock_underwater_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Vegetation";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};





// VOLCANO ROCKS -----------------------------------------------------------------


singleton Material(_23_volcanicrockone_tex_volcano_rocks)
{
	mapTo = "tex_volcano_rocks";

	diffuseMap[0] = "art/shapes/rocks/volcano_rock_dif.dds";
	normalMap[0] = "art/shapes/rocks/volcano_rock_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};



//--- 17_smallrockthree.DAE MATERIALS BEGIN ---

//--- 17_smallrockthree.DAE MATERIALS END ---

//--- 18_smallrockfour.DAE MATERIALS BEGIN ---

//--- 18_smallrockfour.DAE MATERIALS END ---

//--- 15_smallrockone.DAE MATERIALS BEGIN ---

//--- 15_smallrockone.DAE MATERIALS END ---

//--- 16_smallrocktwo.DAE MATERIALS BEGIN ---

//--- 16_smallrocktwo.DAE MATERIALS END ---

//--- 19_smallrockfive.DAE MATERIALS BEGIN ---

//--- 19_smallrockfive.DAE MATERIALS END ---

//--- 02_prismone.DAE MATERIALS BEGIN ---

//--- 02_prismone.DAE MATERIALS END ---

//--- 07_shortcone.DAE MATERIALS BEGIN ---

//--- 07_shortcone.DAE MATERIALS END ---

//--- 08_layeredone.DAE MATERIALS BEGIN ---

//--- 08_layeredone.DAE MATERIALS END ---

//--- 14_ggrockthree.DAE MATERIALS BEGIN ---

//--- 14_ggrockthree.DAE MATERIALS END ---

//--- 01_ovalone.DAE MATERIALS BEGIN ---

//--- 01_ovalone.DAE MATERIALS END ---

//--- 10_outcroppingone.DAE MATERIALS BEGIN ---

//--- 10_outcroppingone.DAE MATERIALS END ---

//--- 09_layeredtwo.DAE MATERIALS BEGIN ---

//--- 09_layeredtwo.DAE MATERIALS END ---

//--- 11_groupone.DAE MATERIALS BEGIN ---
singleton Material(_11_groupone_ColorEffectR88G199B225_material)
{
	mapTo = "ColorEffectR88G199B225-material";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.345098 0.780392 0.882353 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- 11_groupone.DAE MATERIALS END ---

