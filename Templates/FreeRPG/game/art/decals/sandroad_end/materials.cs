//--------------------------------------------------------------
// Copyright (C) Sickhead Games, LLC
//--------------------------------------------------------------



singleton Material(DECAL_sandroadend_material)
{

   mapTo = "sandroadend_diffuse_transparency.png";  
   diffuseMap[0] = "art/decals/sandroad_end/sandroadend_diffuse_transparency.dds";
   normalMap[0] = "art/decals/sandroad_end/sandroadend_normal.dds";

   pixelSpecular[0] = 0;
   specular[0] = "1 1 1 0";
   specularPower [0] = 12;
   specularPower[0] = "12";
   translucent = "1";
   translucentZWrite = "1";
   castShadows = "0";
   materialTag0 = "decal";
   specularMap[0] = "art/decals/sandroad_end/sandroadend_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   vertColor[0] = "1";
   materialTag1 = "RoadAndPath";

};
