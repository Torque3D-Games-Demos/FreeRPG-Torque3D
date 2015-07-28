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

   pixelSpecular = true;
   specular = "1 1 1 0";
   specularPower = 20;
   diffuseMap[0] = "crate_diffuse_transparency.dds";
   overlayMap[0] = "crate_diffuse_transparency.dds";
   normalMap[0] = "crate_normal_specular.dds";
   materialTag0 = "Prop";

};
