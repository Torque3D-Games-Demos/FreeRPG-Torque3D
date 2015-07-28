//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------



//CANOPY TREE: UNIVERSAL BARK

singleton Material(canopytree_bark_lodhi_material)
{
	mapTo = "canopytree_bark_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_diffuse.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";

   forestWindEnabled = 1;
   detailNormalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_detail_normal.dds";
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_barkflat_lodhi_material)
{
	mapTo = "canopytree_barkflat_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_diffuse.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";

   forestWindEnabled = 1;
   detailNormalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_bark_detail_normal.dds";
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   detailScale[0] = "6 6";
   detailNormalMapStrength[0] = "1.5";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};


//CANOPY TREE: UNIVERSAL EXTRAS

singleton Material(canopytree_extras_lodhi_material)
{
	mapTo = "canopytree_extras_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_extras_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_extras_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_extras_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 49;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "26";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};


//CANOPY TREE: NORMAL FOLIAGE

singleton Material(canopytree_fronds_lodhi_material)
{
	mapTo = "canopytree_fronds_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "110";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_lodlo_material)
{
	mapTo = "canopytree_lodlo";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "107";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};




//CANOPY TREE: LIGHT FOLIAGE

singleton Material(canopytree_light_fronds_lodhi_material)
{
	mapTo = "canopytree_light_fronds_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_light_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "110";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_light_lodlo_material)
{
	mapTo = "canopytree_light_lodlo";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_light_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "107";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};




//CANOPY TREE: DARK FOLIAGE

singleton Material(canopytree_dark_fronds_lodhi_material)
{
	mapTo = "canopytree_dark_fronds_lodhi";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_dark_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_fronds_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "110";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};



singleton Material(canopytree_dark_lodlo_material)
{
	mapTo = "canopytree_dark_lodlo";

	diffuseMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_dark_diffuse_transparency.dds";
	normalMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_normal.dds";
	specularMap[0] = "art/shapes/vegetation/trees/canopy/canopytree_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
	emissive[0] = false;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "107";

   forestWindEnabled = 1;
   materialTag0 = "Canopy";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};







//--- canopytree_two.DAE MATERIALS BEGIN ---

//--- canopytree_two.DAE MATERIALS END ---

//--- canopytree_one_novines.DAE MATERIALS BEGIN ---

//--- canopytree_one_novines.DAE MATERIALS END ---

//--- canopytree_three.DAE MATERIALS BEGIN ---


//--- canopytree_three.DAE MATERIALS END ---

//--- shrub_one.DAE MATERIALS BEGIN ---


//--- shrub_one.DAE MATERIALS END ---

