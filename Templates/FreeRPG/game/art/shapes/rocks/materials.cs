//--- okok.DAE MATERIALS BEGIN ---
singleton Material(okok_Clifford)
{
	mapTo = "Clifford";

	diffuseMap[0] = "stone2fixAA";
	normalMap[0] = "RockNormal01";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 45;
	pixelSpecular[0] = 1;
	emissive[0] = false;

	doubleSided = 1;
	translucent = false;
	translucentBlendOp = "None";
   useAnisotropic[0] = "1";
};

//--- okok.DAE MATERIALS END ---


singleton Material(DefaultMaterial2)
{
   mapTo = "stone2fix";
   diffuseMap[0] = "stone2fixAA";
   normalMap[0] = "rock01_NRM";
   doubleSided = "1";
   specularMap[0] = "Cliffs0042_M_SPEC";
   useAnisotropic[0] = "1";
   subSurfaceColor[0] = "0.00392157 0 0 1";
};

singleton Material(sqRock_base01)
{
   mapTo = "base01";
   diffuseColor[0] = "0.588235 0.588235 0.588235 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "45";
   translucentBlendOp = "None";
   diffuseMap[0] = "rock01a";
   normalMap[0] = "RockNormal02";
};

singleton Material(wowRock01_Rockyface)
{
   mapTo = "Rockyface";
   diffuseMap[0] = "stone2fix";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "45";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1";
};

singleton Material(Coll_Rock01_CliffFace002)
{
   mapTo = "CliffFace002";
   diffuseMap[0] = "stone2fixAA";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "45";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1";
   doubleSided = "1";
   detailScale[0] = "1 1";
   detailNormalMap[0] = "normal_rock1";
   detailNormalMapStrength[0] = "3";
   materialTag0 = "RoadAndPath";
};

singleton Material(Coll_Erod_Rock_01_Dirt)
{
   mapTo = "Dirt";
   diffuseMap[0] = "SoilRough0066_57_S";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "45";
   translucentBlendOp = "None";
   normalMap[0] = "SoilRough0066_57_S_NRM";
   doubleSided = "1";
};

singleton Material(Coll_Erod_Rock_01_Grass)
{
   mapTo = "Grass";
   diffuseMap[0] = "Grass0032_L";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(SM_Rock_01_Rocky001)
{
   mapTo = "Rocky001";
   diffuseMap[0] = "rock01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "116";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1";
   doubleSided = "1";
   specularMap[0] = "rock01_DISP";
   useAnisotropic[0] = "1";
};

singleton Material(_3Stones01_Stones001)
{
   mapTo = "Stones001";
   diffuseMap[0] = "rock01a.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "rock01_NRM2.dds";
   detailNormalMap[0] = "normal_rock1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   detailScale[0] = "1 1";
   materialTag0 = "RoadAndPath";
   detailNormalMapStrength[0] = "2";
};

singleton Material(overrock_Overhang)
{
   mapTo = "Overhang";
   diffuseMap[0] = "rock01a.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   detailNormalMap[0] = "normal_rock1";
   materialTag0 = "RoadAndPath";
};

singleton Material(overrock_Overhang)
{
   mapTo = "Overhang";
   diffuseMap[0] = "rock01a";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1";
   detailNormalMap[0] = "normal_rock1";
};

singleton Material(Stone02)
{
   mapTo = "Stone02";
   diffuseMap[0] = "rock01a.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1.dds";
   detailScale[0] = "1 1";
};

singleton Material(wtf_Stones002)
{
   mapTo = "Stones002";
   diffuseMap[0] = "rock01a.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1.dds";
};

singleton Material(Overhang02_OverRock02)
{
   mapTo = "OverRock02";
   diffuseMap[0] = "rock01a.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "normal_rock1.dds";
   useAnisotropic[0] = "1";
};

singleton Material(_20_smallrocksix_tex_underwater_rock)
{
   mapTo = "tex_underwater_rock";
   diffuseMap[0] = "grayrock_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_20_smallrocksix_ColorEffectR6G134B113_material)
{
   mapTo = "ColorEffectR6G134B113-material";
   diffuseColor[0] = "0.0235294 0.52549 0.443137 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_20_smallrocksix_greyrock)
{
   mapTo = "greyrock";
   diffuseMap[0] = "grayrock_diffuse";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_16_smallrocktwo_ColorEffectR196G88B225_material)
{
   mapTo = "ColorEffectR196G88B225-material";
   diffuseColor[0] = "0.768628 0.345098 0.882353 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_19_smallrockfive_ColorEffectR224G143B87_material)
{
   mapTo = "ColorEffectR224G143B87-material";
   diffuseColor[0] = "0.878431 0.560784 0.341177 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_09_layeredtwo_ColorEffectR134G6B6_material)
{
   mapTo = "ColorEffectR134G6B6-material";
   diffuseColor[0] = "0.52549 0.0235294 0.0235294 1";
   diffuseColor[1] = "White";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_06_towerone_ColorEffectR148G177B26_material)
{
   mapTo = "ColorEffectR148G177B26-material";
   diffuseColor[0] = "0.580392 0.694118 0.101961 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_02_prismone_ColorEffectR26G177B26_material)
{
   mapTo = "ColorEffectR26G177B26-material";
   diffuseColor[0] = "0.101961 0.694118 0.101961 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(_08_layeredone_ColorEffectR108G8B136_material)
{
   mapTo = "ColorEffectR108G8B136-material";
   diffuseColor[0] = "0.423529 0.0313726 0.533333 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   effectColor[0] = "0 0 0 0";
};

singleton Material(_23_volcanicrockone_tex_volcano_rocks)
{
   mapTo = "tex_volcano_rocks";
   diffuseMap[0] = "volcano_rock_dif";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   effectColor[0] = "InvisibleBlack";
};
