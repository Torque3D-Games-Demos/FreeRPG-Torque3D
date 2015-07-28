//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

singleton Material(pallet_wood_material)
{
   mapTo = "pallet_wood";  
   baseTex[0] = "";
   bumpTex[0] = "";
   overlayTex[0] = "";

//   detailTex[0] = "crate_diffuse_transparency.png";
//   detailScale[0] = "11 16";
//   detailBumpMap[0] = true;

   pixelSpecular = 1;
   specular = "1 1 1 0";
   specularPower = 20;
   diffuseMap[0] = "crate_diffuse_transparency.dds";
   overlayMap[0] = "crate_diffuse_transparency.dds";
   normalMap[0] = "crate_normal_specular.dds";
   materialTag0 = "Prop";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   specularMap[0] = "art/shapes/physicsShapes/crate_specular.dds";

};

singleton Material(barrel_black)
{
   mapTo = "barrel_black";  
   baseTex[0] = "";
   bumpTex[0] = "";

   detailTex[0] = "";
   detailScale[0] = "11 16";
// detail scale = horizrepeat vertrepeat
//   detailBumpMap[0] = true;

   pixelSpecular = 0;
   specular = "1 1 1 0";
   specularPower = 6;
   diffuseMap[0] = "art/shapes/props/barrels/barreblack_diffuse_transparency.dds";
   detailMap[0] = "";
   normalMap[0] = "art/shapes/props/barrels/barreblack_normal_specular.dds";
   materialTag0 = "Prop";
   detailNormalMap[0] = "art/shapes/props/barrels/barrel_detailnormal.dds";
   specularMap[0] = "art/shapes/props/barrels/barreblack_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";

};


singleton Material(block_short_material)
{
	mapTo = "shrinerocks";

	diffuseMap[0] = "art/shapes/props/blocks/blockflat_diffuse.dds";
	normalMap[0] = "art/shapes/props/blocks/block_normal.dds";
	specularMap[0] = "art/shapes/props/blocks/block_specular.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 81;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   materialTag0 = "Rock";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};



//--- pier_piece_1_posts.DAE MATERIALS BEGIN ---
singleton Material(pier_piece_1_posts_pier_material)
{
	mapTo = "pier_material";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_pier_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_pier_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "61";
   materialTag0 = "Structure";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
};



//--- watertower_broken.DAE MATERIALS END ---


singleton Material(watertower_material)
{
	mapTo = "tex_watertower";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_watertower_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_watertower_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_watertower_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 1;

	doubleSided = false;
	translucent = true;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "114";
   pixelSpecular[0] = "0";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   materialTag0 = "Prop";
   backlight = "1";
};


//--- shed_1_unbroken.DAE MATERIALS BEGIN ---
singleton Material(shed_1_unbroken_tex_covered_structure)
{
	mapTo = "tex_covered_structure";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_covered_structure_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_covered_structure_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_covered_structure_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 31;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   alphaTest = "1";
   alphaRef = "60";
   materialTag0 = "Structure";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};


//--- shed_1_unbroken.DAE MATERIALS END ---

//--- fence_post_base.DAE MATERIALS BEGIN ---
singleton Material(fence_post_base_tex_fence)
{
	mapTo = "tex_fence";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_fence_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_fence_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "Structure";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- fence_post_base.DAE MATERIALS END ---

singleton Material(tex_shrine_material)
{
	mapTo = "tex_shrine";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "73";
   materialTag0 = "Structure";
};


singleton Material(tex_shrine_detail_material)
{
	mapTo = "tex_shrine_detail";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_detail_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_temple_ruins_detail_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "LerpAlpha";
   materialTag0 = "Structure";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- shrine_bowl_A_unbk.DAE MATERIALS END ---


//--- bridge_base.DAE MATERIALS BEGIN ---
singleton Material(bridge_base_tex_bridge)
{
	mapTo = "tex_bridge";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_bridge_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_bridge_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Structure";
   alphaTest = "1";
   alphaRef = "73";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- bridge_base.DAE MATERIALS END ---

//--- barrel_unbk.DAE MATERIALS BEGIN ---


singleton Material(barrel_unbk_tex_barrel__barrelunbroken200_)
{
	mapTo = "tex_barrel__barrelunbroken200_";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_barrel_dif";
	normalMap[0] = "art/shapes/physicsShapes/tex_barrel_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_barrel_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 4;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Prop";
   pixelSpecular[0] = "0";
   detailScale[0] = "28 28";
   detailNormalMap[0] = "art/shapes/props/barrels/barrel_detailnormal.dds";
   detailNormalMapStrength[0] = "1.2";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- barrel_unbk.DAE MATERIALS END ---

//--- barrel_bk.DAE MATERIALS BEGIN ---
singleton Material(barrel_bk_tex_barrel)
{
	mapTo = "tex_barrel";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_barrel_bk_dif.dds";
	normalMap[0] = "art/shapes/physicsShapes/tex_barrel_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_barrel_spc.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 6;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Prop";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};

//--- barrel_bk.DAE MATERIALS END ---

//--- barrelred_bk.DAE MATERIALS BEGIN ---


singleton Material(barrelred_bk_tex_barrel_bk)
{
	mapTo = "tex_barrel_bk";

	diffuseMap[0] = "tex_barrel_bk_dif";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- barrelred_bk.DAE MATERIALS END ---

//--- beached_boat_bk_a.DAE MATERIALS BEGIN ---
singleton Material(beached_boat_bk_a_tex_windows)
{
	mapTo = "tex_windows";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_boat_windows_dif";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   cubemap = "NewLevelSkyCubemap";
   materialTag0 = "Prop";
};

//--- beached_boat_bk_a.DAE MATERIALS END ---

//--- beached_boat_unbk.DAE MATERIALS BEGIN ---
singleton Material(beached_boat_unbk_tex_boat)
{
	mapTo = "tex_boat";

	diffuseMap[0] = "art/shapes/physicsShapes/tex_boat_dif";
	normalMap[0] = "art/shapes/physicsShapes/tex_boat_nrm.dds";
	specularMap[0] = "art/shapes/physicsShapes/tex_boat_spc";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   materialTag0 = "Prop";
};



singleton Material(palletsmall_unbroken_ColorEffectR213G154B229_material)
{
   mapTo = "ColorEffectR213G154B229-material";
   diffuseColor[0] = "0.835294 0.603922 0.898039 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(palletsmall_unbroken_pallet_wood_material)
{
   mapTo = "pallet_wood_material";
   diffuseMap[0] = "crate_diffuse_transparency";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(palletsmall_broken_ColorEffectR225G88B199_material)
{
   mapTo = "ColorEffectR225G88B199-material";
   diffuseColor[0] = "0.882353 0.345098 0.780392 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(shrine_column_C_unbk_ColorEffectR177G88B27_material)
{
   mapTo = "ColorEffectR177G88B27-material";
   diffuseColor[0] = "0.694118 0.345098 0.105882 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(crate_rect_broken_ColorEffectR57G8B136_material)
{
   mapTo = "ColorEffectR57G8B136-material";
   diffuseColor[0] = "0.223529 0.0313726 0.533333 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_ColorEffectR87G224B87_material)
{
   mapTo = "ColorEffectR87G224B87-material";
   diffuseColor[0] = "0.341177 0.878431 0.341177 1";
   specular[0] = "White";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(target_broken_beam)
{
   mapTo = "beam";
   diffuseMap[0] = "art/textures/wood/planks/wood_paneling_grey_01_diffuse.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "art/textures/wood/planks/wood_paneling_grey_01_normal.dds";
   specularMap[0] = "art/textures/wood/planks/wood_paneling_grey_01_specular.dds";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   materialTag0 = "Structure";
   forestWindEnabled = "1";
};

singleton Material(target_broken_ColorEffectR198G224B87_material)
{
   mapTo = "ColorEffectR198G224B87-material";
   diffuseColor[0] = "0.776471 0.878431 0.341177 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
