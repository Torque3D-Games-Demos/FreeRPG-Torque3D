//-----------------------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//-----------------------------------------------------------------------------

singleton Material(darkleafbush_material)
{
   mapTo = "darkleafbush";
   
   baseTex[0] = "";
//   bumpTex[0] = "darkleafbush_normal_specular.png";

//  ADDING DETAIL KILLS TRANSPARENCY HERE  
//   detailTex[0] = "palmfrond_detail.dds";
//   detailScale[0] = "4 4";
//   detailBumpMap[0] = true;

   pixelSpecular = 0;
   specular = "1 1 0.85 0"; // 1 1 0 0 = pure yellow
   specularPower = 54;

   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 84;

   forestWindEnabled = 1;   
   diffuseMap[0] = "art/shapes/vegetation/smallplants/darkleafbush/darkleafbush_diffuse_transparency.dds";
   materialTag0 = "Vegetation";
   normalMap[0] = "art/shapes/vegetation/smallplants/darkleafbush/darkleafbush_normal.dds";
   specularMap[0] = "art/shapes/vegetation/smallplants/darkleafbush/darkleafbush_specular.dds";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   backlight = "1";
};
//--- darkleafbush.DAE MATERIALS BEGIN ---

//--- darkleafbush.DAE MATERIALS END ---

