//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

singleton Material(barrel_black)
{
   mapTo = "barrel_black";  
   baseTex[0] = "";
   bumpTex[0] = "";

   detailTex[0] = "";
   detailScale[0] = "11 16";
// detail scale = horizrepeat vertrepeat
//   detailBumpMap[0] = true;

   pixelSpecular = true;
   specular = "1 1 1 0";
   specularPower = 20;
   diffuseMap[0] = "art/shapes/props/barrels/barreblack_diffuse_transparency.dds";
   detailMap[0] = "";
   normalMap[0] = "art/shapes/props/barrels/barreblack_normal_specular.dds";
   materialTag0 = "Prop";
   detailNormalMap[0] = "art/shapes/props/barrels/barrel_detailnormal.dds";

};
